using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Service;

public class GardenService : BaseService<Garden, GardenDto>
{
    public GardenService(MyGardenCareContext context) : base(context)
    {
    }
}
