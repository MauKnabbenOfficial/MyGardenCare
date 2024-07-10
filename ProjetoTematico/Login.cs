using ProjetoTematico.Controllers;
using ProjetoTematico.Dto;

namespace ProjetoTematico
{
    public partial class Login : Form
    {
        private LoginController _controle;
        public Login()
        {
            InitializeComponent();
            _controle = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = this.txtUser.Text.ToLower();
            string password = this.txtPassword.Text;

            try
            {
                var userLogin = new LoginDto
                {
                    Nome = name,
                    Senha = password
                };

                var login = _controle.DoLogin(userLogin);

                if(login is not null)
                {
                    this.Hide();
                    Main formMain = new Main(login);
                    formMain.ShowDialog();
                    this.Close();
                }

                MessageBox.Show("Usuário não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
