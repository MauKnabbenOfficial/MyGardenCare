using System.ComponentModel.DataAnnotations;

namespace ProjetoTematico.Domain;

public class BaseModel
{
    [Key]
    public int Id { get; set; }
}
