using ProjetoTematico.Domain;

namespace ProjetoTematico.Dto;

public class UserDto : BaseDto
{
    public UserDto() { }

    public int? AccessProfileId { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string Senha { get; set; }
    public int? GardenId { get; set; }

}
