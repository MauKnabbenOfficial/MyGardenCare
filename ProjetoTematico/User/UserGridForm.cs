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
        public UserGridForm()
        {
            InitializeComponent();

            dgvUsuarios.Rows.Add("1","teste","teste@teste.com");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Cells[0].Value != null)
            {
                var usuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                UserForm usuarioForm = new UserForm(usuario)
                {
                    TopLevel = true,
                    Dock = DockStyle.Fill,
                    FormBorderStyle = FormBorderStyle.FixedSingle,
                    Text = $"Editar Usuário {usuario}"
                };
                
                usuarioForm.Show();
            }
        }
    }
}
