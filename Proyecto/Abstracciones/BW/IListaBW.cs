using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracciones.Modelos;

namespace Abstracciones.BW
{
    public interface IListaBW
    {
        public Task<IEnumerable<Lista>> Obtener();
        public Task<Lista> Obtener(Guid Id);
        public Task<Guid> AgregarAsync(Lista lista);
        public Task<Guid> Editar(Lista lista);
        public Task<Guid> Eliminar(Guid Id);
        public Task<int> ObtenerCantidad();
    }
}
