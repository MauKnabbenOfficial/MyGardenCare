using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;

namespace ProjetoTematico.Service;

public class LoginService : BaseService<Login, LoginDto>
{
    public LoginService(MyGardenCareContext context) : base(context)
    {

    }

    public LoginDto DoLogin(LoginDto login)
    {
		try
		{
			User user = _context.Users
				.FirstOrDefault(x => 
				x.Nome == login.Nome && 
				x.Senha == login.Senha);

			if (user is null) return null;

			login.Id = user.Id;

			return login;
		}
		catch (Exception ex)
		{

			throw new Exception(ex.Message);
		}
    }
}
