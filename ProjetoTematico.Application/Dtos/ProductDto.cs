using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Dto;

public class ProductDto : BaseDto
{
    public string Nome { get; set; }
    public int QtdEstoque { get; set; }
    public string Observacoes { get; set; }
}
