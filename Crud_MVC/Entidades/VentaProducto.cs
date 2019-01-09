using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VentaProducto
    {
        public int IdVentaProducto { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }

        public Producto Producto { get; set; }
        public Venta Venta { get; set; }
    }
}
