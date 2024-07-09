using ProjetoTematico.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Dto;

public class WorksDto : BaseDto
{
    public DateTime DataRealizacao { get; set; }
    public bool Realizada { get; set; }
    public int? IdUsuarioRalizador { get; set; }
    public Care Care { get; set; }
}
