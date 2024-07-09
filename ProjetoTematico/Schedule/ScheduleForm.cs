using ProjetoTematico.Controllers;
using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico.Schedule
{
    public partial class ScheduleForm : Form
    {
        ScheduleController _controle;
        UserController _userController;
        PlantController _plantController;

        public ScheduleForm()
        {
            InitializeComponent();
            _controle = new ScheduleController();
            _userController = new UserController();
            _plantController = new PlantController();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            cbPlantas.Items.Clear();
            cbPlantas.Items.Add(new { id = 0, nome = "" });

            var plantas = _plantController.GetAll();
            plantas.ForEach(plant => {
                cbPlantas.Items.Add(new { id = plant.Id, nome = plant.Nome });
            });
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (dtaPeriodoIni.Value.Date > dtaPeriodoFim.Value.Date)
            {
                MessageBox.Show("Data inicial não pode ser maior que a final!","Atenção",buttons: MessageBoxButtons.OK,icon:MessageBoxIcon.Exclamation);
                return;
            }

            var atividades =_controle.GenerateSchedule(dtaPeriodoIni.Value, dtaPeriodoFim.Value);

            if (atividades.Count == 0)
            {
                MessageBox.Show("Não há atividades no período consultado.", "Atenção", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Asterisk);
                return;
            }

            atividades.ForEach(x =>
            {
                var usuario = new UserDto();
                if (x.Work != null && x.Work.IdUsuarioRalizador.HasValue)
                {
                    usuario = _userController.GetById(x.Work.IdUsuarioRalizador.Value);
                }

                dgvCronograma.Rows.Add(
                    x.Work?.Realizada,
                    x.Id,
                    x.Care.Planta.Nome,
                    x.Care.Descricao,
                    usuario.Nome,
                    x.Work?.DataRealizacao
                    );
            });
        }
    }
}
