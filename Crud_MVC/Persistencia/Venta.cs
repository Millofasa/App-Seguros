//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venta()
        {
            this.VentaProducto = new HashSet<VentaProducto>();
        }
    
        public int IdVenta { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public int IdEstado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual EstadoVenta EstadoVenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VentaProducto> VentaProducto { get; set; }
    }
}
