using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;

namespace ProjetoTematico.Service;

public class GardenService : BaseService<Garden, GardenDto>
{
    public GardenService(MyGardenCareContext context) : base(context)
    {
    }
}
