using LaDuartProject.Server.DTO_s;
using LaDuartProject.Server.Entityes;

namespace LaDuartProjet.Core.Interfaces.IServices
{
    public interface IProductoService
    {
        Task<Productos> AddProducto(ProductoDTO productoDTO);
        Task<List<Productos>> UpdateProducto(ProductoDTO productoDTO);
        Task<Productos> GetAllProducto(ProductoDTO productoDTO);
    }
}
