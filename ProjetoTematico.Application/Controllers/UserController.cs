using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class UserController : BaseController
{
    private readonly UserService _service;

    public UserController(UserDto user) : base(user)
    {
        _service = new UserService(_context);
    }

    public List<UserDto> GetAll() => _service.GetAll();
    public UserDto GetById(int id) => _service.GetById(id);
    public int CreateUser(UserDto dto) { CheckManagers(); return _service.Create(dto); }
    public UserDto UpdateUser(UserDto dto) { CheckManagers(); return _service.Update(dto); }
    public void DeleteUser(int id) { CheckManagerChief(); _service.Delete(id); }
    public List<UserDto> GetAllToUpdate() { CheckManagers(); return _service.GetAllToUpdate(); }
}
