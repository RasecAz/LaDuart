using LaDuartProject.Server.DTO_s;
using LaDuartProjet.Core.Interfaces.IServices;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net.Mime;

namespace LaDuartProject.Server.Controllers
{
    [ApiController]
    [EnableCors("MyCors")]
    [Route("api/Producto")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        List<string> messages = new List<string>();
        private readonly IConfiguration _config;

        public ProductoController(IProductoService productoService, IConfiguration config)
        {
            _productoService = productoService;
            _config = config;
        }

        [HttpPost("AddProductos")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductoDTO))]
        [SwaggerOperation
            (
            Summary = "Add Producto",
            Description = "Add Producto"
            )
        ]
        public async Task<IActionResult> AddProducto(ProductoDTO productoDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var resutl = await _productoService.AddProducto(productoDTO);
                if (resutl == null)
                {
                    return BadRequest(messages);
                }
                return Ok(resutl);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status501NotImplemented, ex.Message);
            }
        }

    }
}
