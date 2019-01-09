using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class FachadaPersistencia
    {
        public static FachadaPersistencia instancia;
        public static FachadaPersistencia Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new FachadaPersistencia();
                return instancia;
            }
        }

        internal FachadaPersistencia()
        {

        }

        public bool AddCompania(Entidades.Compania ObjCompania)
        {
            bool Valid = false;
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Compania Obj = new Compania();
                    Obj.Nombre = ObjCompania.Nombre;
                    Obj.Estado = ObjCompania.Estado;
                    

                    Cone.Compania.Add(Obj);
                    Cone.SaveChanges();
                    Valid = true;
                }
            }
            catch (Exception Ex)
            {
                Valid = false;
            }

            return Valid;
        }

        public bool UpdateCompania(Entidades.Compania ObjCompania)
        {
            bool Valid = false;
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Compania Obj = new Compania();
                    Obj = Cone.Compania.Where(x => x.IdCompania == ObjCompania.IdCompania).First();
                    if (Obj.IdCompania != 0)
                    {
                        Obj.Nombre = ObjCompania.Nombre;
                        Cone.SaveChanges();
                        Valid = true;
                    }
                }
            }
            catch (Exception Ex)
            {
                Valid = false;
            }

            return Valid;
        }

        public Entidades.Compania GetCompaniaById(int Id)
        {
            Entidades.Compania ObjCompania = new Entidades.Compania();
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Compania Obj = Cone.Compania.Where(x => x.IdCompania == Id).FirstOrDefault();
                    ObjCompania.IdCompania = Obj.IdCompania;
                    ObjCompania.Nombre = Obj.Nombre;
                }
            }
            catch (Exception Ex)
            {
                ObjCompania = new Entidades.Compania();
            }

            return ObjCompania;
        }

        public List<Entidades.Compania> LstCompania()
        {
            List<Entidades.Compania> LstCompania = new List<Entidades.Compania>();
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {                   
                    LstCompania = (from obj in Cone.Compania
                                   select new Entidades.Compania
                                   {
                                       IdCompania = obj.IdCompania,
                                       Nombre = obj.Nombre,
                                       TotalProductos = Cone.Producto.Where(x => x.IdCompania == obj.IdCompania).Count()
                                   }).ToList();
                }
            }
            catch (Exception Ex)
            {
                LstCompania = new List<Entidades.Compania>();
            }

            return LstCompania;
        }

        public bool AddProducto(Entidades.Producto ObjProducto)
        {
            bool Valid = false;
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Producto Obj = new Producto();
                    Obj.Nombre = ObjProducto.Nombre;
                    Obj.Descripcion = ObjProducto.Descripcion;
                    Obj.IdAsesor = ObjProducto.Asesor.IdAsesor;
                    Obj.IdCompania = ObjProducto.Compania.IdCompania;


                    Cone.Producto.Add(Obj);
                    Cone.SaveChanges();
                    Valid = true;
                }
            }
            catch (Exception Ex)
            {
                Valid = false;
            }

            return Valid;
        }

        public List<Entidades.Producto> LstProductosByCompania(int IdCompania)
        {
            List<Entidades.Producto> Lst = new List<Entidades.Producto>();
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Lst = (from obj in Cone.Producto
                           where obj.IdCompania == IdCompania
                           select new Entidades.Producto
                           {
                               IdProducto = obj.IdProducto,
                               Nombre = obj.Nombre,
                               Descripcion = obj.Descripcion,
                               Asesor = new Entidades.Asesor { IdAsesor = obj.IdAsesor},
                               Compania = new Entidades.Compania{IdCompania = obj.IdCompania}
                           }).ToList();
                }
            }
            catch (Exception Ex)
            {
                Lst = new List<Entidades.Producto>();
            }

            return Lst;
        }

        public bool UpdateProducto(Entidades.Producto ObjProducto)
        {
            throw new NotImplementedException();
        }

        public Entidades.Compania GetProductoById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Entidades.Asesor> LstAsesor()
        {
            List<Entidades.Asesor> LstAsesor = new List<Entidades.Asesor>();
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    LstAsesor = (from obj in Cone.Asesor
                                   select new Entidades.Asesor
                                   {   
                                       IdAsesor = obj.IdAsesor,
                                       Nombre = obj.Nombre,
                                   }).ToList();
                }
            }
            catch (Exception Ex)
            {
                LstAsesor = new List<Entidades.Asesor>();
            }

            return LstAsesor;
        }

        public List<Entidades.Producto> LstProductos()
        {
            List<Entidades.Producto> Lst = new List<Entidades.Producto>();
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Lst = (from obj in Cone.V_ListaProductos
                           orderby obj.IdProducto descending
                           select new Entidades.Producto                           
                           {
                               IdProducto = obj.IdProducto,
                               Nombre = obj.Nombre,
                               Descripcion = obj.Descripcion,
                               Asesor = new Entidades.Asesor { IdAsesor = obj.IdAsesor, Nombre = obj.Asesor },
                               Compania = new Entidades.Compania { IdCompania = obj.IdCompania , Nombre = obj.NombreCompania }
                           }).ToList();
                }
            }
            catch (Exception Ex)
            {
                Lst = new List<Entidades.Producto>();
            }

            return Lst;
        }

        public bool AddItemProducto(Entidades.ItemProducto ObjItem)
        {
            bool Valid = false;
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    ItemProducto Obj = new ItemProducto();
                    Obj.Descripcion = ObjItem.Descripcion;
                    Obj.IdTipoItem = ObjItem.IdTipoItem;
                    Obj.IdProducto = ObjItem.IdProducto;

                    Cone.ItemProducto.Add(Obj);
                    Cone.SaveChanges();
                    Valid = true;
                }
            }
            catch (Exception Ex)
            {
                Valid = false;
            }

            return Valid;
        }

        public List<Entidades.TipoItem> LstTipoItem()
        {
            List<Entidades.TipoItem> Lst = new List<Entidades.TipoItem>();
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Lst = (from obj in Cone.TipoItem
                                 select new Entidades.TipoItem
                                 {
                                     IdTipoItem = obj.IdTipoItem,
                                     Descripcion = obj.Descripcion,
                                 }).ToList();
                }
            }
            catch (Exception Ex)
            {
                Lst = new List<Entidades.TipoItem>();
            }

            return Lst;
        }

        public bool InactivarCompania(int id)
        {
            bool Valid = false;
            try
            {
                using (SegurosEntities Cone = new SegurosEntities())
                {
                    Compania Obj = new Compania();
                    Obj = Cone.Compania.Where(x => x.IdCompania == id).First();
                    if (Obj.IdCompania != 0)
                    {
                        Obj.Estado = false;
                        Cone.SaveChanges();
                        Valid = true;
                    }
                }
            }
            catch (Exception Ex)
            {
                Valid = false;
            }

            return Valid;
        }
    }
}
