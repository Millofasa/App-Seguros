using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compania
    {
        public int IdCompania { get; set; }
        public string Nombre { get; set; }
        public int TotalProductos { get; set; }
        public bool Estado { get; set; }
    }
}
