using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Domain;

public class Login : BaseModel
{
    public string Nome { get; set; }
    public string Senha { get; set; }
}
