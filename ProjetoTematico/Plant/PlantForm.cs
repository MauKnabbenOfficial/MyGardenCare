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
        ScheduleController _schedule;
        CareController _care;
        PlantDto _plant;
        List<CareDto> _cuidados = new List<CareDto>();
        int? _idCuidado;
        int? _indexSelecionado;
        public PlantForm()
        {
            InitializeComponent();
            SetToPanelChildForm();

            _controle = new PlantController();
            _schedule = new ScheduleController();
            _care = new CareController();
        }
        public PlantForm(int id) : this()
        {
            _plant = _controle.GetById(id);
            _cuidados = _care.GetAll().Where(c => c.PlantId == id).ToList();

            PopularCampos();
        }
        private void PopularCampos()
        {
            this.txtNome.Text = _plant.Nome;
            this.txtApelido.Text = _plant.Apelido;
            this.txtObservacoes.Text = _plant.Observacoes;
            this.dataPlantio.Value = _plant.DataPlantio;

            if (_cuidados != null)
            {
                _cuidados.ForEach(c =>
                {
                    CareDto care = new CareDto
                    {
                        Id = c.Id,
                        Descricao = c.Descricao,
                        Observacao = c.Observacao,
                        IndPeriodicidade = c.IndPeriodicidade,
                    };

                    dgvCuidados.Rows.Add(care.Id, care.Descricao,
                        care.Observacao,
                        _schedule.ReturnFrequencyLabel(care.IndPeriodicidade));
                });
            }
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
                for (int i = 0; i < dgvCuidados.Rows.Count - 1; i++)
                {
                    var Id = int.Parse(dgvCuidados.Rows[i].Cells["Id"].Value.ToString());
                    var Descricao = dgvCuidados[1, i].Value.ToString();
                    var Observacao = dgvCuidados[2, i].Value.ToString();
                    var IndPeriodicidade = retornaPeriodicidade(dgvCuidados[3, i].Value);

                    cuidados.Add(new CareDto()
                    {
                        Id = Id,
                        Descricao = Descricao,
                        Observacao = Observacao,
                        IndPeriodicidade = IndPeriodicidade,
                        PlantId = newPlant.Id
                    });
                }
                newPlant.Cuidados = cuidados;

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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private int retornaPeriodicidade(object celula)
        {
            return _schedule.ReturnFrequencyIndex(celula.ToString());
        }
        private void btnAddCuidado_Click(object sender, EventArgs e)
        {
            CareDto newCare = new CareDto
            {
                Id = _idCuidado ?? 0,
                Descricao = txtDescricaoCuidado.Text,
                Observacao = txtObservacoesCuidado.Text,
                IndPeriodicidade = comboPeriodicidade.SelectedIndex,
            };

            if (_indexSelecionado != null)
            {
                dgvCuidados.Rows.RemoveAt(_indexSelecionado.Value);
            }

            dgvCuidados.Rows.Add(newCare.Id, newCare.Descricao, newCare.Observacao, comboPeriodicidade.Text);

            _cuidados.Add(newCare);

            txtDescricaoCuidado.Text = "";
            txtObservacoesCuidado.Text = "";
            comboPeriodicidade.SelectedIndex = -1;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveCuidado_Click(object sender, EventArgs e)
        {
            dgvCuidados.Rows.Remove(dgvCuidados.CurrentRow);
        }

        private void dgvCuidados_DoubleClick(object sender, EventArgs e)
        {
            _indexSelecionado = dgvCuidados.CurrentRow.Index;

            _idCuidado = int.Parse(dgvCuidados.CurrentRow.Cells["Id"].Value.ToString());
            txtDescricaoCuidado.Text = dgvCuidados.CurrentRow.Cells["Descricao"].Value.ToString();
            txtObservacoesCuidado.Text = dgvCuidados.CurrentRow.Cells["Observacoes"].Value.ToString();
            comboPeriodicidade.SelectedIndex = _schedule.ReturnFrequencyIndex(dgvCuidados.CurrentRow.Cells["Periodicidade"].Value.ToString());
        }
    }
}
