using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class ProductoController : Controller
    {

        FachadaNegocio FNegocio;

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Entidades.Producto Obj, string Asesor, string Compania)
        {
            int IdAsesor = 0;
            int IdCompania = 0;

            FNegocio = new FachadaNegocio();
            Entidades.Asesor ObjAsesor = new Entidades.Asesor();
            Entidades.Compania ObjCompania = new Entidades.Compania();

            int.TryParse(Asesor, out IdAsesor);
            int.TryParse(Compania, out IdCompania);

            try
            {
                bool IsOk = false;

                ObjCompania.IdCompania = IdCompania;
                Obj.Compania = ObjCompania;
                ObjAsesor.IdAsesor = IdAsesor;
                Obj.Asesor = ObjAsesor;

                IsOk = FNegocio.AddProducto(Obj);
                if (IsOk)
                {
                    ViewBag.Message = "Producto Creado Correctamente";
                }
                return View();
            }
            catch (Exception Ex)
            {
                ViewBag.ErrorMessage = Ex.Message;
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult LstProductosByCompania(int IdCompania)
        {
            List<Entidades.Producto> Lst = new List<Entidades.Producto>();
            FNegocio = new FachadaNegocio();
            Lst = FNegocio.LstProductosByCompania(IdCompania);
            return View("LstProductosByCompania", Lst);
        }


        public PartialViewResult LstProductos()
        {
            List<Entidades.Producto> Lst = new List<Entidades.Producto>();
            FNegocio = new FachadaNegocio();
            Lst = FNegocio.LstProductos();
            return PartialView("_LstProductos", Lst);
        }

        public ActionResult LstProductosVenta()
        {
            List<Entidades.Producto> Lst = new List<Entidades.Producto>();
            FNegocio = new FachadaNegocio();
            Lst = FNegocio.LstProductos();
            return View("LstProductosVenta", Lst);
        }

        public PartialViewResult CreateProduct(Entidades.Producto Obj, string Asesor, string Compania)
        {
            if (Obj.IdProducto != 0)
            {
                int IdAsesor = 0;
                int IdCompania = 0;

                FNegocio = new FachadaNegocio();
                Entidades.Asesor ObjAsesor = new Entidades.Asesor();
                Entidades.Compania ObjCompania = new Entidades.Compania();

                int.TryParse(Asesor, out IdAsesor);
                int.TryParse(Compania, out IdCompania);

                try
                {
                    bool IsOk = false;

                    ObjCompania.IdCompania = IdCompania;
                    Obj.Compania = ObjCompania;
                    ObjAsesor.IdAsesor = IdAsesor;
                    Obj.Asesor = ObjAsesor;

                    IsOk = FNegocio.AddProducto(Obj);
                    if (IsOk)
                    {
                        ViewBag.Message = "Producto Creado Correctamente";
                    }
                    return PartialView("_CreateProduct");
                }
                catch (Exception Ex)
                {
                    ViewBag.ErrorMessage = Ex.Message;
                    return PartialView("_CreateProduct");
                }
            }
            else
            {
                return PartialView("_CreateProduct");
            }

        }
    }
}
