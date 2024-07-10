using Microsoft.EntityFrameworkCore;
using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoTematico.Service;

public class CareService : BaseService<Care, CareDto>
{
    public CareService(MyGardenCareContext context) : base(context)
    {
    }
    public int Create(CareDto dto)
    {
        try
        {
            var verificar = _context.Set<Care>().AsNoTracking().FirstOrDefault(x => x.Id == dto.Id);

            if (verificar is not null)
            {
                throw new Exception("Entidade já existe!");
            }

            var entidade = dto.MapTo<Care>();

            _context.Set<Care>().Add(entidade);
            _context.SaveChanges();

            return entidade.Id;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public List<CareDto> ReturnCaresTimeSpan(DateTime dateStart, DateTime dateEnd)
    {
        /*Periodicidades        
         Diário
         Semanal
         Quinzenal
         Mensal
         */

        var ret = new List<CareDto>();

        var daysSpan = (dateEnd.Date - dateStart.Date).Days;
        var cares = this.GetAll();

        cares.ForEach(c =>
        {
            var divisor = 1;
            switch (c.IndPeriodicidade)
            {
                case 1:
                    divisor = 7;
                    break;
                case 2:
                    divisor = 15;
                    break;
                case 3:
                    divisor = 30;
                    break;
            }
            float qtdListar = (float)daysSpan / divisor;

            for (var i = 0; i < qtdListar; i++)
            {
                ret.Add(new CareDto()
                {
                    Id = c.Id,
                    AccessProfileId = c.AccessProfileId,
                    Descricao = c.Descricao,
                    IndPeriodicidade = c.IndPeriodicidade,
                    Observacao = c.Observacao,
                    PlantId = c.PlantId,
                });
            }        
        });

        return ret;        
    }
}
