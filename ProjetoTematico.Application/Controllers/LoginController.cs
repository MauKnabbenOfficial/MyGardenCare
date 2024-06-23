using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class LoginController : BaseController
{
    public readonly LoginService _service;

    public LoginController()
    {
        _service = new LoginService(_context);
    }

    public LoginDto DoLogin(LoginDto dto) => _service.DoLogin(dto);
}
