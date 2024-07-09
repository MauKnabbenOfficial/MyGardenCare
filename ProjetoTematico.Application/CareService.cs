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
    public List<CareDto> ReturnCaresTimeSpan(DateTime dateStart, DateTime dateEnd)
    {
        /*Periodicidades        
         Diário
         Semanal
         Quinzenal
         Mensal
         */

        var ret = new List<CareDto>();

        var timespan = dateEnd - dateStart;
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
            var daysSpan = (int)timespan.Days / divisor;

            for (var i = 0; i > daysSpan; i++)
            {
                ret.Add(new CareDto()
                {
                    Id = c.Id,
                    AccessProfileId = c.AccessProfileId,
                    Descricao = c.Descricao,
                    IndPeriodicidade = c.IndPeriodicidade,
                    Observacao = c.Observacao,
                    Planta = c.Planta,
                });
            }        
        });

        return ret;        
    }
}
