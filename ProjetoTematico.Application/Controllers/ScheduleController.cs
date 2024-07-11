using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class ScheduleController : BaseController
{
    public readonly ScheduleService _service;
    public readonly PlantController _plantController;

    public ScheduleController(UserDto user) : base(user)
    {
        _service = new ScheduleService(_context);
        _plantController = new PlantController(user);
    }

    public List<ScheduleDto> GetAll() => _service.GetAll();
    public ScheduleDto GetById(int id) => _service.GetById(id);
    public int CreateSchedule(ScheduleDto dto) => _service.Create(dto);
    public ScheduleDto UpdateSchedule(ScheduleDto dto) => _service.Update(dto);
    public bool DeleteSchedule(int id) => _service.Delete(id);

    public List<ScheduleDto> GenerateSchedule(DateTime dateI, DateTime dateF, int plantId, bool somenteFeitas)
    {
        return _service.GenerateSchedule(dateI, dateF, plantId, somenteFeitas, _plantController);
    }

    public string ReturnFrequencyLabel(int index) => _service.ReturnFrequencyLabel(index);
    public int ReturnFrequencyIndex(string label) => _service.ReturnFrequencyIndex(label);
}
