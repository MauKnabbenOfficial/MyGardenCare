using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoTematico.Controllers;
using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico.Schedule
{
    public partial class ScheduleForm : Form
    {
        UserDto _usuarioLogado;

        ScheduleController _controle;
        UserController _userController;
        PlantController _plantController;
        WorksController _worksController;

        public ScheduleForm(UserDto usuarioLogado)
        {
            InitializeComponent();

            _usuarioLogado = usuarioLogado;

            _controle = new ScheduleController();
            _userController = new UserController();
            _plantController = new PlantController();
            _worksController = new WorksController();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            cbPlantas.Items.Clear();
            var plantas = new List<PlantDto>();

            plantas.Add(new PlantDto());
            plantas.AddRange(_plantController.GetAll());
            
            cbPlantas.DataSource = plantas;
            cbPlantas.DisplayMember = "Nome";
            cbPlantas.ValueMember = "Id";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvCronograma.Rows.Clear();

            if (dtaPeriodoIni.Value.Date > dtaPeriodoFim.Value.Date)
            {
                MessageBox.Show("Data inicial não pode ser maior que a final!", "Atenção", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Exclamation);
                return;
            }
            var idPlanta = -1;
            if (cbPlantas.SelectedIndex > 0)
            {
                idPlanta = ((PlantDto)cbPlantas.SelectedItem).Id;
            }
            var atividades = _controle.GenerateSchedule(dtaPeriodoIni.Value.Date, dtaPeriodoFim.Value, idPlanta, tipSomenteFeitas.Checked);

            if (atividades.Count == 0)
            {
                MessageBox.Show("Não há atividades no período consultado.", "Atenção", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Asterisk);
                return;
            }

            atividades.ForEach(x =>
            {
                var usuario = new UserDto();
                if (x.Work != null && x.Work.IdUsuarioRealizador.HasValue)
                {
                    usuario = _userController.GetById(x.Work.IdUsuarioRealizador.Value);
                }

                var planta = _plantController.GetById(x.Care.PlantId);

                dgvCronograma.Rows.Add(
                    x.Work?.Realizada,
                    planta.Id,
                    planta.Nome,
                    x.Care.Id,
                    x.Care.Descricao,
                    x.Care.Observacao,
                    usuario.Nome,
                    x.Work?.DataRealizacao
                    );
            });
        }

        private void dgvCronograma_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCronograma.Rows.Count < 2)
            {
                return;
            }

            var planta = dgvCronograma.CurrentRow.Cells["Planta"].Value.ToString();
            var atividade = dgvCronograma.CurrentRow.Cells["Atividade"].Value.ToString();

            var r = MessageBox.Show($"Confirma realização da atividade {atividade} na planta {planta}?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _worksController.CreateWorks(new WorksDto()
                {
                    DataRealizacao = DateTime.Now,
                    CareId = int.Parse(dgvCronograma.CurrentRow.Cells["CareId"].Value.ToString()),
                    IdUsuarioRealizador = _usuarioLogado.Id,
                    Realizada = true
                });

                dgvCronograma.CurrentRow.Cells["IsFeito"].Value = true;
                dgvCronograma.CurrentRow.Cells["Usuario"].Value = _usuarioLogado.Nome;
                dgvCronograma.CurrentRow.Cells["DtaRealizacao"].Value = DateTime.Now.ToString("d");

                MessageBox.Show("Atividade realizada com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
