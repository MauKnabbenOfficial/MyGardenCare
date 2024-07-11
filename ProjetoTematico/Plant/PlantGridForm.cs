using ProjetoTematico.Controllers;
using ProjetoTematico.Dto;
using ProjetoTematico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico.Plant
{
    public partial class PlantGridForm : Form
    {
        PlantController _controle;
        public PlantGridForm(UserDto usuarioLogado)
        {
            InitializeComponent();
            _controle = new PlantController();

            if (usuarioLogado.AccessProfileId != 1) { 
                this.btnExcluir.Visible = false;
            }
        }

        private void PlantGridForm_Load(object sender, EventArgs e)
        {
            dgvPlantas.Rows.Clear();

            var plantas = _controle.GetAll();

            plantas.ForEach(p =>
            {
                dgvPlantas.Rows.Add(p.Id, p.Nome, p.DataPlantio.ToString("dd'/'MM'/'yyyy"));
            });
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlantas.CurrentRow.Cells[0].Value != null)
            {
                var planta = int.Parse(dgvPlantas.CurrentRow.Cells[0].Value.ToString());
                PlantForm plantForm = new PlantForm(planta)
                {
                    TopLevel = true,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    Text = $"Editar Planta {planta}"
                };

                plantForm.ShowDialog();

                PlantGridForm_Load(sender, e);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPlantas.CurrentRow.Cells[0].Value != null)
            {
                var res = MessageBox.Show($"Tem certeza que deseja excluir a planta {dgvPlantas.CurrentRow.Cells[1].Value}", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var id = int.Parse(dgvPlantas.CurrentRow.Cells[0].Value.ToString());
                    _controle.DeletePlant(id);
                }
                PlantGridForm_Load(sender, e);
            }
        }
    }
}
