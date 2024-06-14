using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Service;

public class PlantService : BaseService<Plant, PlantDto>
{
    public PlantService(MyGardenCareContext context) : base(context)
    {
    }
}