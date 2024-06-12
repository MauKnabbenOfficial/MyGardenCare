using Microsoft.EntityFrameworkCore.Diagnostics;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class UserController
{
    private readonly MyGardenCareContext _context;
    private readonly UserService _service;

    public UserController()
    {
        _context = new MyGardenCareContext();
        _service = new UserService(_context);
    }

    public UserDto GetById(int id) => _service.GetById(id);
    public int CreateUser(UserDto dto) => _service.CreateUser(dto);
    public UserDto UpdateUser(UserDto dto) => _service.UpdateUser(dto);
    public void DeleteUser(UserDto dto) => _service.DeleteUser(dto);
}
