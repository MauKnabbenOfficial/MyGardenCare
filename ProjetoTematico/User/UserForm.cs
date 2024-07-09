using ProjetoTematico.Dto;
using ProjetoTematico.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico
{
    public partial class UserForm : BaseControl
    {
        private UserController _controle;
        UserDto _usuarioLogado;
        UserDto _user;
        public UserForm(UserDto usuarioLogado)
        {
            _controle = new UserController();
            InitializeComponent();
            SetToPanelChildForm();

            _usuarioLogado = usuarioLogado;
            validaPerfilAcesso();
        }
        public UserForm(UserDto usuarioLogado, int id) : this(usuarioLogado)
        {
            _user = _controle.GetById(id);

            PopularCampos();
        }
        private void validaPerfilAcesso()
        {
            if (_usuarioLogado.AccessProfileId.Value != 1)
            {                
                btnSave.Visible = false;
            }
        }

        private void PopularCampos()
        {
            this.txtNome.Text = _user.Nome;
            this.txtCpf.Text = _user.Cpf;
            this.txtTelefone.Text = _user.Telefone;
            this.txtEmail.Text = _user.Email;
            this.txtSenha.Text = _user.Senha;
            this.IsAdmin.Checked = _user.AccessProfileId == 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var Nome = this.txtNome.Text;
            var Cpf = this.txtCpf.Text;
            var Telefone = this.txtTelefone.Text;
            var Email = this.txtEmail.Text;
            var IsAdmin = this.IsAdmin.Checked;
            var Senha = this.txtSenha.Text;

            try
            {
                UserDto newUser = new UserDto
                {
                    Id = _user?.Id ?? 0,
                    AccessProfileId = IsAdmin ? 1: 0,
                    Nome = Nome,
                    Cpf = Cpf,
                    Telefone = Telefone,
                    Email = Email,
                    IsAdmin = IsAdmin,
                    Senha = Senha
                };

                if (_user != null)
                {
                    _controle.UpdateUser(newUser);
                    MessageBox.Show("Usuario atualizado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _controle.CreateUser(newUser);
                    MessageBox.Show("Usuario cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimparCampos()
        {
            this.txtNome.Clear();
            this.txtSenha.Clear();
            this.txtEmail.Clear();
            this.txtTelefone.Clear();
            this.txtCpf.Clear();
            this.IsAdmin.Checked = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text.Length > 10) 
            {
                txtTelefone.Mask = "(00) 0 0000-0000";
            }
        }
    }
}
