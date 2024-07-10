using ProjetoTematico.Controllers;
using ProjetoTematico.Dto;
using System.Data;

namespace ProjetoTematico.Garden
{
    public partial class GardenForm : BaseControl
    {
        private UserDto _currentUser;
        private GardenController _controle;
        private UserController _controleUsuario;

        public GardenForm(UserDto user)
        {
            InitializeComponent();
            _currentUser = user;
            _controle = new GardenController(user);
            _controleUsuario = new UserController(user);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var nome = this.txtNomeJardim.Text;
                var local = this.txtLocal.Text;
                var id = _currentUser.Id;

                var garden = new GardenDto
                {
                    ManagerChiefId = id,
                    Name = nome,
                    Local = local,
                };

                _controle.CreateGarden(garden);

                MessageBox.Show("Jardim cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
