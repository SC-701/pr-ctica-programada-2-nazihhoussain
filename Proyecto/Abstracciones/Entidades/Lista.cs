using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Entidades
{
    public class Lista
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Desc { get; set; }
        public string? FechaI { get; set; }
        public string? FechaF { get; set; }
        public string? Asigando { get; set; }
        public string? Estado { get; set; }

    }
}
