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
    public partial class UserForm : Form
    {
        private UserController _controle;
        public UserForm()
        {
            _controle = new UserController();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var Nome = this.txtNome.Text;
            var Cpf = this.txtCpf.Text;
            var Telefone = this.txtPhone.Text;

            try
            {
                UserDto newUser = new UserDto
                {
                    Nome = Nome,
                    Cpf = Cpf,
                    Telefone = Telefone
                };

                _controle.CreateUser(newUser);

                MessageBox.Show("Usuario cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
