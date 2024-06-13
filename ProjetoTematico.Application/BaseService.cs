using Microsoft.EntityFrameworkCore;
using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using System.Reflection;
using System.Transactions;

namespace ProjetoTematico.Service;

public class BaseService<TModel, TDto> : IServiceBase where TModel : BaseModel, new() where TDto : BaseDto, new()
{
    protected readonly MyGardenCareContext _context;

    public BaseService(MyGardenCareContext context)
    {
        _context = context;
    }

    public List<TDto> GetAll()
    {
        try
        {
            List<TModel> entries = _context.Set<TModel>().AsNoTracking().ToList();

            return entries.MapToList<TModel, TDto>();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        
    }

    public TDto GetById(int id)
    {
        try
        {
            var verificar = _context.Set<TModel>().AsNoTracking().FirstOrDefault(x => x.Id == id);

            if (verificar is null)
            {
                throw new Exception($"ID '{id}' não  encontrado!");
            }

            var entidade = verificar.MapTo<TDto>();

            return entidade;
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
    }

    public int Create(TDto dto)
    {
        try
        {
            var verificar = _context.Set<TModel>().AsNoTracking().FirstOrDefault(x => x.Id == dto.Id);

            if (verificar is not null)
            {
                throw new Exception("Entidade já existe!");
            }

            var entidade = dto.MapTo<TModel>();

            _context.Set<TModel>().Add(entidade);
            _context.SaveChanges();

            return entidade.Id;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public TDto Update(TDto dto)
    {
        try
        {
            var id = dto.Id;

            var verificar = _context.Set<TModel>().AsNoTracking().Where(x => x.Id == id).FirstOrDefault();

            if (verificar is null)
            {
                throw new Exception("Entidade não encontrada!");
            }

            var entidade = dto.MapTo<TModel>();

            _context.Set<TModel>().Update(entidade);
            _context.SaveChanges();

            return GetById(id);

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public bool Delete(int id)
    {
        try
        {
            var verificar = _context.Set<TModel>().AsNoTracking().Where(x => x.Id == id).FirstOrDefault();

            if (verificar is null)
            {
                throw new Exception("Entidade não encontrada!");
            }

            _context.Set<TModel>().Remove(verificar);
            _context.SaveChanges();

            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }


}
