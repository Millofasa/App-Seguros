using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FachadaNegocio
    {
        public bool AddCompania(Entidades.Compania ObjCompania)
        {
            try
            {
                NCompania Obj = new NCompania();
                return Obj.AddCompania(ObjCompania);
            }
            catch (Exception Ex)
            {
                
                throw;
            }
        }

        public List<Entidades.Compania> LstCompania()
        {
            try
            {
                NCompania ObjCompania = new NCompania();
                return ObjCompania.LstCompania();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool UpdateCompania(Entidades.Compania ObjCompania)
        {
            try
            {
                NCompania Obj = new NCompania();
                return Obj.UpdateCompania(ObjCompania);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Entidades.Compania GetCompaniaById(int id)
        {
            try
            {
                NCompania ObjCompania = new NCompania();
                return ObjCompania.GetCompaniaById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddProducto(Entidades.Producto ObjProducto)
        {
            try
            {
                NProducto Obj = new NProducto();
                return Obj.AddProducto(ObjProducto);
            }
            catch (Exception Ex)
            {

                throw;
            }
        }

        public List<Entidades.Producto> LstProductosByCompania(int IdCompania)
        {
            try
            {
                NProducto Obj = new NProducto();
                return Obj.LstProductosByCompania(IdCompania);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Entidades.Asesor> LstAsesor()
        {
            try
            {
                NAsesor Obj = new NAsesor();
                return Obj.LstAsesor();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Entidades.Producto> LstProductos()
        {
            try
            {
                NProducto Obj = new NProducto();
                return Obj.LstProductos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddItemProducto(Entidades.ItemProducto ObjItem)
        {
            try
            {
                NProducto Obj = new NProducto();
                return Obj.AddItemProducto(ObjItem);
            }
            catch (Exception Ex)
            {

                throw;
            }
        }

        public List<Entidades.TipoItem> LstTipoItem()
        {
            try
            {
                NTipoItem Obj = new NTipoItem();
                return Obj.LstTipoItem();
            }
            catch (Exception Ex)
            {

                throw;
            }
            
        }       

        public bool InactivarCompania(int id)
        {
            try
            {
                NCompania Obj = new NCompania();
                return Obj.InactivarCompania(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
