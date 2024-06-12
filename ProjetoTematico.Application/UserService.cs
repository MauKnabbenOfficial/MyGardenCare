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

    public UserDto GetById(int id)
    {
        var usuario = _context.Users.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();

        if (usuario is not null) return new UserDto(usuario);

        throw new Exception("Usuario não encontrado!");
    }

    public int CreateUser(UserDto userDto)
    {
        try
        {
            var todos = GetAll();
            var verificar = _context.Users.AsNoTracking().Where(x => x.Cpf == userDto.Cpf).FirstOrDefault();

            if (verificar is not null)
            {       
                throw new Exception("Usuário já existe!");
            }

            User user = new User
            {
                Nome = userDto.Nome,
                Cpf = userDto.Cpf,
                Telefone = userDto.Telefone
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return user.Id;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public UserDto UpdateUser(UserDto userDto)
    {
        try
        {
            var id = userDto.Id;

            var verificar = _context.Users.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();

            if (verificar is null)
            {
                throw new Exception("Usuário não existe!");
            }

            verificar = new User
            {
                Id = userDto.Id,
                AccessProfileId = userDto.AccessProfileId,
                Cpf = userDto.Cpf,
                Nome = userDto.Nome,
                Telefone = userDto.Telefone

            };

            _context.Users.Update(verificar);
            _context.SaveChanges();

            return GetById(id);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void DeleteUser(UserDto userDto)
    {

    }
}
