using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class GardenController : BaseController
{
    private readonly GardenService _service;
    public GardenController()
    {
        _service = new GardenService(_context);
    }

    public List<GardenDto> GetAll() => _service.GetAll();
    public GardenDto GetById(int id) => _service.GetById(id);
    public int CreateGarden(GardenDto dto) => _service.Create(dto);
    public GardenDto UpdateGarden(GardenDto dto) => _service.Update(dto);
    public bool DeleteGarden(int id) => _service.Delete(id);
}
