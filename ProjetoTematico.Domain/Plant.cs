using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Domain;

public class Plant : BaseModel
{
    [Key]
    public int Id { get; set; }
    public int AccessProfileId { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Observacoes { get; set; }
    public DateTime DataPlantio { get; set; }
}
