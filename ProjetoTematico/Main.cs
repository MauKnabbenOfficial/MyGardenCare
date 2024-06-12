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
    public partial class Main : BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void usuarioBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            UserForm userForm = new UserForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(userForm);

            userForm.Show();
        }
    }
}
