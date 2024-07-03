using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracciones.BC;
using Abstracciones.DA;
using Abstracciones.Modelos;

namespace BC
{
    public class ListaBC : IListaBC
    {
        public Lista DarFormato(Lista lista)
        {
            lista.Nombre = NombreMayuscula(lista.Nombre);
            return lista;
        }

        private string NombreMayuscula(string nombre)
        {
            return nombre.ToUpper();
        }
    }
}
