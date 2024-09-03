using LaDuartProject.Server.DTO_s;
using LaDuartProject.Server.Entityes;
using LaDuartProjet.Core.Interfaces.IServices;
using LaDuartProjet.Core.Interfaces.Repositories;

namespace LaDuartProjet.Core.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IAsyncRepository<Productos> _asyncRepository;
        public ProductoService(IAsyncRepository<Productos> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }
        public async Task<Productos> AddProducto(ProductoDTO productoDTO)
        {
            var productos = new Productos
            {
                Nombre = productoDTO.Nombre,
                Descripcion = productoDTO.Descripcion,
                Cantidad = productoDTO.Cantidad,
                Precio = productoDTO.Precio,
            };
            return await _asyncRepository.AddAsync(productos);
        }

        public Task<Productos> GetAllProducto(ProductoDTO productoDTO)
        {
            throw new NotImplementedException();
        }

        public Task<List<Productos>> UpdateProducto(ProductoDTO productoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
