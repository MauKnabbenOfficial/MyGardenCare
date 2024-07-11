using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Domain;

public class Care : BaseModel
{
    public int? AccessProfileId { get; set; }
    public string Descricao { get; set; }
    public string Observacao { get; set; }
    public int IndPeriodicidade { get; set; }
    public int PlantId { get; set; }
}
