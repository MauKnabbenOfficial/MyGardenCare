using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;

namespace ProjetoTematico.Service;

public class AccessProfileService : BaseService<AccessProfile, AccessProfileDto>
{
    public AccessProfileService(MyGardenCareContext context) : base(context)
    {
    }
}
