using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProducto
    {
        internal bool AddProducto(Entidades.Producto ObjProducto)
        {
            try
            {
                return FachadaPersistencia.Instancia.AddProducto(ObjProducto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal List<Entidades.Producto> LstProductosByCompania(int IdCompania)
        {
            try
            {

                return FachadaPersistencia.Instancia.LstProductosByCompania(IdCompania);

            }
            catch (Exception)
            {

                throw;
            }
        }

        internal bool UpdateCompania(Entidades.Producto ObjProducto)
        {
            return FachadaPersistencia.Instancia.UpdateProducto(ObjProducto);
        }

        internal Entidades.Compania GetProductoById(int id)
        {
            return FachadaPersistencia.Instancia.GetProductoById(id);
        }

        internal List<Entidades.Producto> LstProductos()
        {
            return FachadaPersistencia.Instancia.LstProductos();
        }

        internal bool AddItemProducto(Entidades.ItemProducto ObjItem)
        {
            return FachadaPersistencia.Instancia.AddItemProducto(ObjItem);
        }
    }
}
