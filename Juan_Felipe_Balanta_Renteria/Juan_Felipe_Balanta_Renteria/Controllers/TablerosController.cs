using Juan_Felipe_Balanta_Renteria.Entities;
using Juan_Felipe_Balanta_Renteria.Servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Juan_Felipe_Balanta_Renteria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TablerosController : ControllerBase
    {
        private readonly ITableroServices tableroService;

        public TablerosController(ITableroServices tableroService)
        {
            this.tableroService = tableroService;
        }

        [HttpGet("obtener")]
        public async Task<ActionResult<List<TableroEntity>>> Get()
        {
            return await tableroService.GetAllTablero();
        }

        [HttpGet("obtener/{id:int}")]
        public async Task<ActionResult<TableroEntity>> GetById(int id)
        {
            return await tableroService.GetTablero(id);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CreateTablero([FromBody] TableroEntity entity)
        {
            tableroService.CreateTablero(entity);
            return NoContent();
        }

        [HttpPut("modificar")]
        public async Task<IActionResult> UpdateTablero([FromBody] TableroEntity entity)
        {
            tableroService.UpdateTablero(entity);
            return NoContent();
        }

        [HttpDelete("eliminar/{id:int}")]
        public async Task<IActionResult> EliminarTablero(int id)
        {
            tableroService.ELiminarTablero(id);
            return NoContent();
        }
    }
}
