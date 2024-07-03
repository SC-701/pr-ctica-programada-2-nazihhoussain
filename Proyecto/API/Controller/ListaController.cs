using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Core;
using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.Modelos;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListaController : ControllerBase
    {
        private IListaBW _listaBW;

        public ListaController(IListaBW listaBW)
        {
            _listaBW = listaBW;
        }
        [HttpPost]
        public async Task<IActionResult> AgregarAsync([FromBody] Lista lista)
        {
            var resultado = await _listaBW.AgregarAsync(lista);
            return CreatedAtAction(nameof(Obtener), new { Id = resultado }, lista);
        }
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Lista lista)
        {
            var listaExiste = await _listaBW.Obtener(lista.Id);
            if (listaExiste == null)
                return NotFound();
            return Ok(await _listaBW.Editar(lista));
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Eliminar([FromRoute] Guid Id)
        {
            var entrenadorExiste = await _listaBW.Obtener(Id);
            if (entrenadorExiste == null)
                return NotFound();
            await _listaBW.Eliminar(Id);
            return NoContent();
        }
        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            return Ok(await _listaBW.Obtener());
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> Obtener([FromRoute] Guid Id)
        {
            return Ok(await _listaBW.Obtener(Id));
        }
    }
}
