using ProjetoTematico.Domain;

namespace ProjetoTematico.Dto;

public class GardenDto : BaseDto
{
    public int ManagerChiefId { get; set; }
    public string? Name { get; set; }
    public string? Local { get; set; }
}
