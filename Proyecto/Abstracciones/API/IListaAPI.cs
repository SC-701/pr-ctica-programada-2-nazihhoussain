using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abstracciones.Modelos;

namespace Abstracciones.API
{
    public interface IListaAPI
    {
        [HttpGet]
        public Task<IActionResult> Obtener();
        [HttpGet]
        public Task<IActionResult> Obtener(Guid Id);
        [HttpPost]
        public Task<IActionResult> AgregarAsync(Lista lista);
        [HttpPut]
        public Task<IActionResult> Editar(Lista ista);
        [HttpDelete]
        public Task<IActionResult> Eliminar(Guid Id);
    }
}
