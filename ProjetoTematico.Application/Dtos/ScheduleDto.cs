using ProjetoTematico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Dto;

public class ScheduleDto : BaseDto
{
    public CareDto Care { get; set; }
    public WorksDto? Work { get; set; }
}
