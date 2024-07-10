using ProjetoTematico.Domain;
using ProjetoTematico.Dto;
using ProjetoTematico.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Service;

public class PlantService : BaseService<Plant, PlantDto>
{
    CareService careService;
    public PlantService(MyGardenCareContext context) : base(context)
    {
        careService = new CareService(context);
    }
    public int Create(PlantDto dto)
    {
        var ret = base.Create(dto);
        if (ret != 0 && dto.Cuidados != null)
        {
            dto.Cuidados.ForEach(c =>
            {
                c.PlantId = ret;
                careService.Create(c);
            });
        }

        return ret;
    }
    public PlantDto Update(PlantDto dto)
    {
        var ret = base.Update(dto);
        if (dto.Cuidados != null)
        {
            dto.Cuidados.ForEach(c =>
            {
                c.PlantId = ret.Id;
                try
                {
                    careService.Update(c);
                }
                catch (Exception ex)
                {
                    careService.Create(c);
                }
            });
        }

        return ret;
    }
}