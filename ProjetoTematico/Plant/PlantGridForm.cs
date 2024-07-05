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
        public PlantGridForm()
        {
            InitializeComponent();
        }

        private void PlantGridForm_Load(object sender, EventArgs e)
        {
            //var plantas = _controle.GetAll();
            var plantas = new List<PlantDto>();
            plantas.Add(new PlantDto()
            {
                Id = 1,
                Nome = "Samambaia",
                DataPlantio = DateTime.Now,
            });
            plantas.Add(new PlantDto()
            {
                Id = 2,
                Nome = "Palmeira",
                DataPlantio = DateTime.Now.AddDays(1),
            });
            plantas.Add(new PlantDto()
            {
                Id = 3,
                Nome = "Flor",
                DataPlantio = DateTime.Now.AddDays(-1),
            });


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
                
                plantForm.Show();
            }

        }
    }
}
