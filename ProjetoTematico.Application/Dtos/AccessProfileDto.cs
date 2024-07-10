using ProjetoTematico.Domain;

namespace ProjetoTematico.Dto;

public class AccessProfileDto : BaseDto
{
    public Permissao PermissaoLevel { get; set; }
}
