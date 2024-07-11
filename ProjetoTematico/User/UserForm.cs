using ProjetoTematico.Dto;
using ProjetoTematico.Controllers;
using ProjetoTematico.Domain;
using Microsoft.VisualBasic.ApplicationServices;

namespace ProjetoTematico
{
    public partial class UserForm : BaseControl
    {
        private UserDto _currentUser;
        private UserController _controle;
        private AccessProfileController _accessProfileControle;
        private GardenController _gardenControle;
        private UserDto ManagerChief;
        UserDto _user;

        public UserForm(UserDto usuarioLogado, int? id = null)
        {
            _currentUser = usuarioLogado;
            _controle = new UserController(usuarioLogado);
            _accessProfileControle = new AccessProfileController();
            _gardenControle = new GardenController(usuarioLogado);

            InitializeComponent();
            SetToPanelChildForm();

            PreparaDados();

            if (id is not null) { 
                _user = _controle.GetById(id.Value);
                PopularCampos();
            }
            else _user = new UserDto();

        }

        private void PopularCampos()
        {
            this.txtNome.Text = _user.Nome;
            this.txtCpf.Text = _user.Cpf;
            this.txtPhone.Text = _user.Telefone;

        }

        private void PreparaDados()
        {

            try
            {
                _controle.CheckManagerChief();
                ManagerChief = _currentUser;
            }
            catch
            {
                if (_currentUser.GardenId is null) { 
                    throw new Exception("É necessário ter ao menos um Jardim antes de cadastrar um Usuario!");
                }

                var garden = _gardenControle.GetById(_currentUser.GardenId.Value);
                ManagerChief = _controle.GetById(garden.ManagerChiefId);
            }

            var gardens = _gardenControle.GetAll();

            comboBoxPermissao.DataSource = Enum.GetValues(typeof(Permissao));

            comboBoxJardim.DataSource = gardens.Where(x => x.ManagerChiefId == ManagerChief.Id).ToList();
            comboBoxJardim.DisplayMember = "Name";
            comboBoxJardim.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var Nome = this.txtNome.Text;
            var Cpf = this.txtCpf.Text;
            var Telefone = this.txtPhone.Text;

            try
            {
                var profile = new AccessProfile() { PermissaoLevel = (Permissao)comboBoxPermissao.SelectedItem };
                var profileDto = profile.MapTo<AccessProfileDto>();
                var idAccessProfile = _accessProfileControle.CreateAccess(profileDto);

                var gardenSelect = (GardenDto)comboBoxJardim.SelectedItem;


                UserDto newUser = new UserDto
                {
                    Id = _user != null? _user.Id : 0,
                    Nome = Nome,
                    Cpf = Cpf,
                    Telefone = Telefone,
                    AccessProfileId = idAccessProfile,
                    GardenId = gardenSelect.Id,
                    Senha = "1234"
                };

                if (_user != null)
                {
                    _controle.UpdateUser(newUser);
                    MessageBox.Show("Usuario atualizado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _controle.CreateUser(newUser);
                    MessageBox.Show("Usuario cadastrado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimparCampos()
        {
            this.txtNome.Clear();
            this.txtPhone.Clear();
            this.txtCpf.Clear();
        }
    }
}
