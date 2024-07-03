using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracciones.BC;
using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.Modelos;
using Abstracciones.SG;

namespace BW
{
    public class ListaBW : IListaBW
    {
        private IListaDA _listaDA;
        private IListaBC _listaBC;

        public ListaBW(IListaDA listaDA, IListaBC listaBC)
        {
            _listaDA = listaDA;
            _listaBC = listaBC;
        }

        public async Task<Guid> AgregarAsync(Abstracciones.Modelos.Lista lista)
        {
            var presonaConFormato = _listaBC.DarFormato(lista);
            return await _listaDA.AgregarAsync(presonaConFormato);
        }

        public async Task<Guid> Editar(Abstracciones.Modelos.Lista lista)
        {
            return await _listaDA.Editar(lista);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            return _listaDA.Eliminar(Id);
        }

        public Task<IEnumerable<Abstracciones.Modelos.Lista>> Obtener()
        {
            return _listaDA.Obtener();
        }

        public Task<Abstracciones.Modelos.Lista> Obtener(Guid Id)
        {
            return _listaDA.Obtener(Id);
        }

        public Task<int> ObtenerCantidad()
        {
            return _listaDA.ObtenerCantidad();
        }
    }
}
