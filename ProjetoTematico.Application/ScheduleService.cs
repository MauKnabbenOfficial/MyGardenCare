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
    public ScheduleService(MyGardenCareContext context) : base(context)
    {
    }
}