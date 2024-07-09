using Microsoft.EntityFrameworkCore;
using ProjetoTematico.Controllers;
using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Service;

public class ScheduleService : BaseService<Schedule, ScheduleDto>
{
    protected readonly MyGardenCareContext _context;
    public ScheduleService(MyGardenCareContext context) : base(context)
    {
        _context = context;
}
    public List<ScheduleDto> GenerateSchedule(DateTime dateI, DateTime dateF)
    {
        var ret = new List<ScheduleDto>();

        PlantController plantController = new PlantController();
        var plants = plantController.GetAll();

        CareService careService = new CareService(_context);
        var cares = careService.ReturnCaresTimeSpan(dateI, dateF);


        WorksService worksService = new WorksService(_context);
        var works = worksService.ReturnWorksDateSpan(dateI, dateF);

        cares.ForEach(c => {
            ret.Add(new ScheduleDto
            {
                Id = c.Id,
                Care = c,
                Work = works.Find(w => w.Care.Id == c.Id)
            });
        });

        return ret;
    }
}