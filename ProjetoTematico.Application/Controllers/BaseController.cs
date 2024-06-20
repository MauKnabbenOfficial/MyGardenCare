using ProjetoTematico.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Controllers;

public class BaseController
{
    public readonly MyGardenCareContext _context = new MyGardenCareContext();
}
