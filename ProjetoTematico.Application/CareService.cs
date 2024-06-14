using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;

namespace ProjetoTematico.Service;

public class CareService : BaseService<Care, CareDto>
{
    public CareService(MyGardenCareContext context) : base(context)
    {
    }
}
