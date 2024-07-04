using ProjetoTematico.Controllers;
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

namespace ProjetoTematico.Plant
{
    public partial class PlantForm : Form
    {
        PlantController _controle;
        List<CareDto> _cuidados = new List<CareDto>();
        public PlantForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Nome = this.txtNome.Text;
            var Apelido = this.txtApelido.Text;
            var Observacoes = this.txtObservacoes.Text;
            var DataPlantio = this.dataPlantio.Value;

            try
            {
                PlantDto newPlant = new PlantDto
                {
                    Nome = Nome,
                    Apelido = Apelido,
                    Observacoes = Observacoes,
                    DataPlantio = DataPlantio
                };

                _controle.CreatePlant(newPlant);

                MessageBox.Show("Planta cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCuidado_Click(object sender, EventArgs e)
        {
            CareDto newCare = new CareDto
            {
                Descricao = txtDescricaoCuidado.Text,
                Observacao = txtObservacoesCuidado.Text,
                IndPeriodicidade = comboPeriodicidade.SelectedIndex,
            };

            dgvCuidados.Rows.Add(newCare.Descricao, newCare.Observacao, comboPeriodicidade.Text);

            _cuidados.Add(newCare);
        }        
    }
}
