using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Domain;

public class Garden : BaseModel
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Endereco { get; set; }
}
