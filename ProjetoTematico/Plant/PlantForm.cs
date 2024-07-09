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

namespace ProjetoTematico.Plant
{
    public partial class PlantForm : BaseControl
    {
        PlantController _controle;
        PlantDto _plant;
        List<CareDto> _cuidados = new List<CareDto>();
        public PlantForm()
        {
            InitializeComponent();
            SetToPanelChildForm();
        }
        public PlantForm(int id) : this()
        {
            _plant = _controle.GetById(id);

            PopularCampos();
        }
        private void PopularCampos()
        {
            this.txtNome.Text = _plant.Nome;
            this.txtApelido.Text = _plant.Apelido;
            this.txtObservacoes.Text = _plant.Observacoes;
            this.dataPlantio.Value = _plant.DataPlantio;
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
                    Id = _plant?.Id ?? 0,
                    Nome = Nome,
                    Apelido = Apelido,
                    Observacoes = Observacoes,
                    DataPlantio = DataPlantio
                };

                var cuidados = new List<CareDto>();
                for (int i = 0; i < dgvCuidados.Rows.Count; i++)
                {
                    cuidados.Add(new CareDto()
                    {
                        Descricao = dgvCuidados[0, i].Value.ToString(),
                        Observacao = dgvCuidados[1, i].Value.ToString(),
                        IndPeriodicidade = retornaPeriodicidade(dgvCuidados[2, i].Value),
                        //Planta = newPlant.MapTo<Domain.Plant>()
                    });
                }
                if (_plant != null)
                {
                    _controle.UpdatePlant(newPlant);
                    MessageBox.Show("Planta atualizada com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _controle.CreatePlant(newPlant);
                    MessageBox.Show("Planta cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int retornaPeriodicidade(object celula)
        {
            if (celula.ToString().CompareTo("Diário") == 0)
            {
                //Diario
                return 0;
            }
            if (celula.ToString().CompareTo("Semanal") == 0)
            {
                //Semanal
                return 1;
            }
            if (celula.ToString().CompareTo("Quinzenal") == 0)
            {
                //Quinzenal
                return 2;
            }
            //Mensal
            return 3;

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCuidado_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvCuidados.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    dgvCuidados.Rows.RemoveAt(r.Index);
                }
            }
        }
    }
}
