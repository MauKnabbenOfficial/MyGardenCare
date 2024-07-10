using ProjetoTematico.Controllers;
using ProjetoTematico.Domain;
using ProjetoTematico.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Dto;

public class PlantDto : BaseDto
{
    public PlantDto() { }
    public PlantDto(Plant plant)
    {
        Id = plant.Id;
        AccessProfileId = plant.AccessProfileId;
        Nome = plant.Nome;
        Apelido = plant.Apelido;
        Observacoes = plant.Observacoes;
        DataPlantio = plant.DataPlantio;
        Cuidados = MontarListaCuidados(plant.Id);
    }
    private List<CareDto> MontarListaCuidados(int id)
    {
        var ret = new List<CareDto>();
        CareController careController = new CareController();
        ret = careController.GetAll().Where(c => c.PlantId == id).ToList();

        return ret;
    }

    public int? AccessProfileId { get; set; }
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public string Observacoes { get; set; }
    public DateTime DataPlantio { get; set; }
    public List<CareDto> Cuidados { get; set; }
}
