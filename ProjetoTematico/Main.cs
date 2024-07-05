using ProjetoTematico.Garden;
using ProjetoTematico.Plant;
using ProjetoTematico.Product;
using ProjetoTematico.User;
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

        public void usuarioBtnMenuItem_Click(object sender, EventArgs e)
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

        private void plantaBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            PlantForm plantForm = new PlantForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(plantForm);

            plantForm.Show();
        }

        private void jardimBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            GardenForm gardenForm = new GardenForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(gardenForm);

            gardenForm.Show();
        }

        private void produtoBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            ProductForm gardenForm = new ProductForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(gardenForm);

            gardenForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            UserGridForm userGridForm = new UserGridForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(userGridForm);
            userGridForm.Show();
        }

        private void consultaPlantaBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            PlantGridForm plantGridForm = new PlantGridForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(plantGridForm);
            plantGridForm.Show();
        }

        private void consultaProdutoBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            ProductGridForm productGridForm = new ProductGridForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(productGridForm);
            productGridForm.Show();
        }
    }
}
