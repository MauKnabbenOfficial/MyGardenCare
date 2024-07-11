using ProjetoTematico.Controllers;
using ProjetoTematico.Dto;
using ProjetoTematico.Garden;

namespace ProjetoTematico
{
    public partial class Main : BaseForm
    {
        private LoginDto _currentLogin;
        private UserDto _currentUser;
        public Main(LoginDto _login)
        {
            InitializeComponent();
            _currentLogin = _login;
            _currentUser = AutenticacaoController.GetById(_currentLogin.Id);
        }

        private void usuarioBtnMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();//Fecha possiveis paginas abertas

            UserForm userForm = new UserForm(_currentUser)
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(userForm);//Adiciona pagina painel principal

            userForm.Show();//Mostra pagina painel princial (ela vem "escondida")
        }

        private void jardimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();//Fecha possiveis paginas abertas no painel principal

            GardenForm gardenForm = new GardenForm(_currentUser)
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };

            this.mainPanel.Controls.Add(gardenForm);//Adiciona pagina painel principal

            gardenForm.Show(); //Mostra pagina painel princial (ela vem "escondida")
        }
    }
}
