using ProjetoTematico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Dto;

public class UserDto
{
    public UserDto() { }

    public UserDto(User user) {
        Id = user.Id;
        AccessProfileId = user.AccessProfileId;
        Nome = user.Nome;
        Cpf = user.Cpf;
        Telefone = user.Telefone;
    }

    public int Id { get; set; }
    public int? AccessProfileId { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
}
