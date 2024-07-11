namespace ProjetoTematico.Domain;

public class Garden : BaseModel
{
    public int ManagerChiefId { get; set; }
    public string Name { get; set; }
    public string Local { get; set; }
}