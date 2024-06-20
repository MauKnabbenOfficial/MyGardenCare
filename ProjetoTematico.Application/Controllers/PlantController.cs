using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class PlantController : BaseController
{
    public readonly PlantService _service;

    public PlantController()
    {
        _service = new PlantService(_context);
    }

    public List<PlantDto> GetAll() => _service.GetAll();
    public PlantDto GetById(int id) => _service.GetById(id);
    public int CreatePlant(PlantDto dto) => _service.Create(dto);
    public PlantDto UpdatePlant(PlantDto dto) => _service.Update(dto);
    public bool DeletePlant(int id) => _service.Delete(id);
}
