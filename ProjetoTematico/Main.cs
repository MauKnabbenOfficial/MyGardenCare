using ProjetoTematico.Controllers;
using ProjetoTematico.Dto;
using ProjetoTematico.Garden;
using ProjetoTematico.Plant;
using ProjetoTematico.Product;
using ProjetoTematico.Schedule;
using ProjetoTematico.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTematico
{
    public partial class Main : BaseForm
    {
        UserController _userController;
        GardenController _gardenController;
        UserDto _usuarioLogado;
        GardenDto _jardim;

        public Main()
        {
            InitializeComponent();

            _userController = new UserController();
            _gardenController = new GardenController();
        }
        public Main(LoginDto usuario) : this()
        {
            _usuarioLogado = _userController.GetById(usuario.Id);

            //Header
            headerLabel.Text = $"Bem vindo(a) {_usuarioLogado.Nome}!";
            footerLabel.Text = $"{DateTime.Now.ToString("d")}";
            try
            {
                _jardim = _gardenController.GetById(1);

                //Footer                   
                footerLabel.Text = $"Trabalhando no {_jardim.Nome} - {DateTime.Now.ToString("d")}";
            }
            catch (Exception ex)
            {
                primeiroAcesso();
            }
        }

        private void primeiroAcesso()
        {
            cadastrosToolStripMenuItem.DropDownItems[2].Visible = false;
            cadastrosToolStripMenuItem.DropDownItems[3].Visible = false;

            consultasToolStripMenuItem.DropDownItems[1].Visible = false;
            consultasToolStripMenuItem.DropDownItems[2].Visible = false;
            consultasToolStripMenuItem.DropDownItems[3].Visible = false;

            headerLabel.Text += $"\nConfigure seu Jardim em Menu > Cadastos > Jardim!";
            return;
        }
        public void lerJardimCriado(int id)
        {
            _jardim = _gardenController.GetById(1);
            if (_jardim != null)
            {
                headerLabel.Text = headerLabel.Text.Split('\n')[0];
                footerLabel.Text = $"Trabalhando no {_jardim.Nome} - {DateTime.Now.ToString("d")}";
            }
        }

        public void usuarioBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            UserForm userForm = new UserForm(_usuarioLogado)
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

            GardenForm gardenForm = new GardenForm(this, _usuarioLogado)
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

            UserGridForm userGridForm = new UserGridForm(_usuarioLogado)
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

        private void consultaCronogramaBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();

            ScheduleForm scheduleForm = new ScheduleForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(scheduleForm);
            scheduleForm.Show();
        }

        private void LayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
