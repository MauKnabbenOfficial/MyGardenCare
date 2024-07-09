using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoTematico.Domain;

namespace ProjetoTematico.Dto;

public class CareDto : BaseDto
{
    public CareDto()
    {
      
    }
    public CareDto(Care care)
    {
        AccessProfileId = care.AccessProfileId;
        Descricao = care.Descricao;
        Observacao = care.Observacao;
        IndPeriodicidade = care.IndPeriodicidade;
    }    
    public int? AccessProfileId { get; set; }
    public string Descricao { get; set; }
    public string Observacao { get; set; }
    public int IndPeriodicidade { get; set; }
    public Plant Planta { get; set; }
}
