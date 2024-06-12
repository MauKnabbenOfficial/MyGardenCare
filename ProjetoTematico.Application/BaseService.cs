using Microsoft.EntityFrameworkCore;
using ProjetoTematico.Domain;
using ProjetoTematico.Persistence;
using System.Reflection;
using System.Transactions;

namespace ProjetoTematico.Service;

public class BaseService<TModel, TDto> : IServiceBase where TModel : BaseModel, new() where TDto : class, new()
{
    protected readonly MyGardenCareContext _context;

    public BaseService(MyGardenCareContext context)
    {
        _context = context;
    }

    public List<TDto> GetAll()
    {
        List<TModel> entries = _context.Set<TModel>().AsNoTracking().ToList();

        var teste = entries.MapToList<TModel, TDto>();
        return teste;
    }

    
}
