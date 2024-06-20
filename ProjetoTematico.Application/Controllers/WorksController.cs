using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class WorksController : BaseController
{
    public readonly WorksService _service;

    public WorksController()
    {
        _service = new WorksService(_context);
    }

    public List<WorksDto> GetAll() => _service.GetAll();
    public WorksDto GetById(int id) => _service.GetById(id);
    public int CreateWorks(WorksDto dto) => _service.Create(dto);
    public WorksDto UpdateWorks(WorksDto dto) => _service.Update(dto);
    public bool DeleteWorks(int id) => _service.Delete(id);
}
