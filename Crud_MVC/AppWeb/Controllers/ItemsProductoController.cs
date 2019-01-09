using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class ItemsProductoController : Controller
    {
        FachadaNegocio FNegocio;

        // GET: ItemsProducto
        public ActionResult Index()
        {
            return View();
        }

        // GET: ItemsProducto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: ItemsProducto/Create
        [HttpPost]
        public JsonResult Create(int IdProducto, int IdItem, string Descripcion)
        {
            try
            {
                bool IsOk = false;
                FNegocio = new FachadaNegocio();
                ItemProducto ObjItem = new ItemProducto();
                ObjItem.IdProducto = IdProducto;
                ObjItem.IdTipoItem = IdItem;
                ObjItem.Descripcion = Descripcion;

                IsOk = FNegocio.AddItemProducto(ObjItem);
                if (IsOk)
                {
                    return Json(new
                    {
                        succes = true,
                        message = "Item creado correctamente"
                    }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new
                    {
                        succes = false,
                        message = "Errror Creando un nuevo item."
                    }, JsonRequestBehavior.AllowGet);
                }
            }

            catch (Exception ex)
            {
                return Json(new
                {
                    succes = false,
                    message = ex.Message
                }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: ItemsProducto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemsProducto/Edit/5
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

        // GET: ItemsProducto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemsProducto/Delete/5
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
    }
}
