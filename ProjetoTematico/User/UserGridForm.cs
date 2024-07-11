using Microsoft.VisualBasic.FileIO;
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

namespace ProjetoTematico.User
{
    public partial class UserGridForm : Form
    {
        UserController _controller;
        UserDto _usuarioLogado;
        public UserGridForm(UserDto usuarioLogado)
        {
            InitializeComponent();
            _controller = new UserController();

            _usuarioLogado = usuarioLogado;

            if (usuarioLogado.AccessProfileId != 1)
            {
                btnExcluir.Visible = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Cells[0].Value != null)
            {
                var id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                UserForm usuarioForm = new UserForm(_usuarioLogado, id)
                {
                    TopLevel = true,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    Text = $"Editar Usuário {id}"
                };

                usuarioForm.ShowDialog();

                UserGridForm_Load(sender, e);
            }
        }

        private void UserGridForm_Load(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();

            var users = _controller.GetAll();
            foreach (var user in users)
            {
                if (user.Id == 1)
                {
                    continue;
                }

                dgvUsuarios.Rows.Add(user.Id, user.Nome, user.Email, user.AccessProfileId == 1 ? "Sim" : "Não");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Cells[0].Value != null)
            {                
                var res = MessageBox.Show($"Tem certeza que deseja excluir o usuário {dgvUsuarios.CurrentRow.Cells[1].Value}", "EXCLUIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                    _controller.DeleteUser(id);
                }
                UserGridForm_Load(sender, e);
            }
        }
    }
}
