using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemProducto
    {
        public int IdItemProducto { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoItem { get; set; }
        public int IdProducto { get; set; }

        public  Producto Producto { get; set; }
        public TipoItem TipoItem { get; set; }
    }
}
