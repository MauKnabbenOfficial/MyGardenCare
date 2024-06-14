using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Service;

public class WorksService : BaseService<Works, WorksDto>
{
    public WorksService(MyGardenCareContext context) : base(context)
    {
    }
}
