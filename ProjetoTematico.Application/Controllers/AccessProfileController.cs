using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class AccessProfileController
{
    private readonly MyGardenCareContext _context;
    private readonly AccessProfileService _service;

    public AccessProfileController()
    {
        _context = new MyGardenCareContext();
        _service = new AccessProfileService(_context);
    }

    public AccessProfileDto GetById(int id) => _service.GetById(id);
    public int CreateAccess(AccessProfileDto dto) => _service.Create(dto);
    public AccessProfileDto UpdateAccess(AccessProfileDto dto) => _service.Update(dto);
    public bool DeleteAccess(int id) => _service.Delete(id);
}
