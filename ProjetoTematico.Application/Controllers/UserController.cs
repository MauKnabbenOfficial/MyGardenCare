using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class UserController : BaseController
{
    private readonly UserService _service;

    public UserController()
    {
        _service = new UserService(_context);
    }

    public UserDto GetById(int id) => _service.GetById(id);
    public int CreateUser(UserDto dto) => _service.Create(dto);
    public UserDto UpdateUser(UserDto dto) => _service.Update(dto);
    public void DeleteUser(int id) => _service.Delete(id);
}
