using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class GardenController : BaseController
{
    private readonly GardenService _service;
    private readonly UserController _userController;
    public GardenController(UserDto user) : base(user)
    {
        _service = new GardenService(_context);
        _userController = new UserController(user);
    }

    public List<GardenDto> GetAll() => _service.GetAll();
    public GardenDto GetById(int id) => _service.GetById(id);
    public int CreateGarden(GardenDto dto) {

        try
        {
            _userController.CheckSysAdmin();
        }
        catch
        {
            _userController.CheckManagerChief();
        }

        return _service.Create(dto);
    }
    public GardenDto UpdateGarden(GardenDto dto) => _service.Update(dto);
    public bool DeleteGarden(int id) => _service.Delete(id);
}
