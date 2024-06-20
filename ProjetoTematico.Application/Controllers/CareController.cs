using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class CareController : BaseController
{
    private readonly CareService _service;
    public CareController()
    {
        _service = new CareService(_context);
    }

    public List<CareDto> GetAll() => _service.GetAll();
    public CareDto GetById(int id) => _service.GetById(id);
    public int CreateCare(CareDto dto) => _service.Create(dto);
    public CareDto UpdateCare(CareDto dto) => _service.Update(dto);
    public bool DeleteCare(int id) => _service.Delete(id);
}
