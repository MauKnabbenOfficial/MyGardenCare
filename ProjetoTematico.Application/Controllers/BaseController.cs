using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class BaseController(UserDto? user = null)
{
    public readonly MyGardenCareContext _context = new MyGardenCareContext();
    private readonly UserDto? _user = user;

    public void CheckSysAdmin()
    {
        if (_user is null || _user.AccessProfileId is null) throw new Exception("Usuário sem permissão!");

        using (var verificacao = new MyGardenCareContext())
        {
            var _check = new UserService(verificacao);

            if(!_check.isSysAdmin(_user.AccessProfileId.Value)) throw new Exception("Usuário sem permissão!");
        }
    }

    public void CheckManagers()
    {
        if (_user is null || _user.AccessProfileId is null) throw new Exception("Usuário sem permissão!");

        using (var verificacao = new MyGardenCareContext())
        {
            var _check = new UserService(verificacao);

            if (!_check.isManagers(_user.AccessProfileId.Value)) throw new Exception("Usuário sem permissão!");
        }
    }

    public void CheckManagerChief()
    {
        if (_user is null || _user.AccessProfileId is null) throw new Exception("Usuário sem permissão!");

        using (var verificacao = new MyGardenCareContext())
        {
            var _check = new UserService(verificacao);

            if (!_check.isManagerChief(_user.AccessProfileId.Value)) throw new Exception("Usuário sem permissão!");
        }
    }

    public void CheckisManager()
    {
        if (_user is null || _user.AccessProfileId is null) throw new Exception("Usuário sem permissão!");

        using (var verificacao = new MyGardenCareContext())
        {
            var _check = new UserService(verificacao);

            if (!_check.isManager(_user.AccessProfileId.Value)) throw new Exception("Usuário sem permissão!");
        }
    }
}
