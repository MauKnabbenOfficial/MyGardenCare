using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using ProjetoTematico.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Controllers;

public class AutenticacaoController
{
    public static UserDto GetById(int id) { 
        using(var _context = new MyGardenCareContext())
        {
            var _service = new UserService(_context);
            return _service.GetById(id);
        }
    }
}
