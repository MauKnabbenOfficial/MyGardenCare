using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Domain;

public class Works : BaseModel
{    public bool Realizada { get; set; }
    public DateTime? DataRealizacao { get; set; }
    public int? IdUsuarioRealizador { get; set; }
    public int CareId { get; set; }
}
