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
    public List<ScheduleDto> GenerateSchedule(DateTime dateI, DateTime dateF, int plantId, bool somenteFeitas, PlantController plantController)
    {
        var ret = new List<ScheduleDto>();      

        CareService careService = new CareService(_context);
        var cares = careService.ReturnCaresTimeSpan(dateI, dateF);

        if (plantId > -1) {
            cares = cares.Where(c => c.PlantId == plantId).ToList();
        }

        WorksService worksService = new WorksService(_context);
        
        var works = worksService.ReturnWorksDateSpan(dateI, dateF);

        cares.ForEach(c => {
            var work = works.Find(w => w.CareId == c.Id);
            if (work != null)
            {
                works.Remove(work);
            }
            ret.Add(new ScheduleDto
            {
                Id = c.Id,
                Care = c,
                Work = work
            });
        });

        if (somenteFeitas)
        {
            ret = ret.Where(r => r.Work != null).ToList();
        }

        return ret;
    }
    public string ReturnFrequencyLabel(int indFreq)
    {
        switch (indFreq)
        {
            case 0:
                return "Diário";
            case 1:
                return "Semanal";
            case 2:
                return "Quinzenal";
            case 3:
                return "Mensal";
            default:
                return "";
        }
    }
    public int ReturnFrequencyIndex(string txtFreq)
    {
        switch (txtFreq)
        {
            case "Diário":
                return 0;
            case "Semanal":
                return 1;
            case "Quinzenal":
                return 2;
            case "Mensal":
                return 3;
            default:
                return -1;
        }
    }
}