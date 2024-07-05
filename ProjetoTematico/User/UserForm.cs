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
        public UserForm()
        {
            _controle = new UserController();
            InitializeComponent();
            SetToPanelChildForm();
        }
        public UserForm(int id) : this()
        {
            //var user = _controle.GetById(id);
            var user = new UserDto(){ 
               Id = id,
               Nome = "Teste",
               Cpf = "00000000010",
               Email = "email@email.com",
               IsAdmin = true,
               Telefone = "999999999"
            };

            PopularCampos(user);
        }

        private void PopularCampos(UserDto user)
        {
            this.txtNome.Text = user.Nome;
            this.txtCpf.Text = user.Cpf;
            this.txtPhone.Text = user.Telefone;
            this.txtEmail.Text = user.Email;
            this.IsAdmin.Checked = user.IsAdmin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var Nome = this.txtNome.Text;
            var Cpf = this.txtCpf.Text;
            var Telefone = this.txtPhone.Text;
            var Email = this.txtEmail.Text;
            var IsAdmin = this.IsAdmin.Checked;

            try
            {
                UserDto newUser = new UserDto
                {
                    Nome = Nome,
                    Cpf = Cpf,
                    Telefone = Telefone,
                    Email = Email,
                    IsAdmin = IsAdmin
                };

                _controle.CreateUser(newUser);

                MessageBox.Show("Usuario cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }        

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
