using ProjetoTematico.Domain;

namespace ProjetoTematico.Dto;

public class UserDto : BaseDto
{
    public UserDto() { }

    public UserDto(User user) {
        Id = user.Id;
        AccessProfileId = user.AccessProfileId;
        Nome = user.Nome;
        Cpf = user.Cpf;
        Telefone = user.Telefone;
    }

    public int? AccessProfileId { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
}
