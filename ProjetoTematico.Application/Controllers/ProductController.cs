using ProjetoTematico.Dto;
using ProjetoTematico.Service;

namespace ProjetoTematico.Controllers;

public class ProductController : BaseController
{
    public readonly ProductService _service;

    public ProductController()
    {
        _service = new ProductService(_context);
    }

    public List<ProductDto> GetAll() => _service.GetAll();
    public ProductDto GetById(int id) => _service.GetById(id);
    public int CreateProduct(ProductDto dto) => _service.Create(dto);
    public ProductDto UpdateProduct(ProductDto dto) => _service.Update(dto);
    public bool DeleteProduct(int id) => _service.Delete(id);
}
