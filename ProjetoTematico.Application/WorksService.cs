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
    public List<WorksDto> ReturnWorksDateSpan(DateTime dateStart, DateTime dateEnd)
    {
        return _context.Set<Works>().Select(w => w.MapTo<WorksDto>())
            .Where(w => w.DataRealizacao.CompareTo(dateStart) >= 0 &&
                        w.DataRealizacao.CompareTo(dateEnd) <= 0).ToList();
    }
}
