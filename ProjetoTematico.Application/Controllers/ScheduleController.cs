using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class ScheduleController : BaseController
{
    public readonly ScheduleService _service;

    public ScheduleController()
    {
        _service = new ScheduleService(_context);
    }

    public List<ScheduleDto> GetAll() => _service.GetAll();
    public ScheduleDto GetById(int id) => _service.GetById(id);
    public int CreateSchedule(ScheduleDto dto) => _service.Create(dto);
    public ScheduleDto UpdateSchedule(ScheduleDto dto) => _service.Update(dto);
    public bool DeleteSchedule(int id) => _service.Delete(id);
    public List<ScheduleDto> GenerateSchedule(DateTime dateI, DateTime dateF, int plantId, bool somenteFeitas) 
        => _service.GenerateSchedule(dateI, dateF, plantId, somenteFeitas);
    public string ReturnFrequencyLabel(int index) => _service.ReturnFrequencyLabel(index);
    public int ReturnFrequencyIndex(string label) => _service.ReturnFrequencyIndex(label);
}
