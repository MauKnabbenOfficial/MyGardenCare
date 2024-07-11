using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Domain;

public class Product : BaseModel
{
    public string Nome { get; set; }
    public int QtdEstoque { get; set; }
    public string Observacoes { get; set; }
}
