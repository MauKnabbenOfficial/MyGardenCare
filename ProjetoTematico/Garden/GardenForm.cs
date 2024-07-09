using ProjetoTematico.Controllers;
using ProjetoTematico.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico.Garden
{
    public partial class GardenForm : Form
    {
        GardenController _controller;
        Main _main;
        GardenDto _jardim;
        UserDto _usuarioLogado;
        public GardenForm(Main main, UserDto usuarioLogado)
        {
            InitializeComponent();
            _controller = new GardenController();
            _main = main;
            _usuarioLogado = usuarioLogado;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                if (_jardim != null)
                {
                    _controller.UpdateGarden(new Dto.GardenDto()
                    {
                        Id = 1,
                        Nome = txtNome.Text,
                        Descricao = txtDescricao.Text,
                        Endereco = txtEndereco.Text,
                    });
                }
                else
                {
                    id = _controller.CreateGarden(new Dto.GardenDto()
                    {
                        Id = 1,
                        Nome = txtNome.Text,
                        Descricao = txtDescricao.Text,
                        Endereco = txtEndereco.Text,
                    });
                }

                _main.lerJardimCriado(id);

                MessageBox.Show("Salvo com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            this.Close();
        }

        private void GardenForm_Load(object sender, EventArgs e)
        {
            if (_usuarioLogado.AccessProfileId != 1)
            {
                btnSave.Visible = false;
            }
            try
            {
                _jardim = _controller.GetById(1);

                if (_jardim != null)
                {
                    txtNome.Text = _jardim.Nome;
                    txtDescricao.Text = _jardim.Descricao;
                    txtEndereco.Text = _jardim.Endereco;
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
