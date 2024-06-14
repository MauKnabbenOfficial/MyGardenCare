using Microsoft.EntityFrameworkCore;
using ProjetoTematico.Domain;
using ProjetoTematico.Persistence;
using ProjetoTematico.Dto;

namespace ProjetoTematico.Service;

public class UserService : BaseService<User, UserDto>
{
    public UserService(MyGardenCareContext context) : base(context)
    {

    }
}
