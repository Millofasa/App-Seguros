using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class CompaniaController : Controller
    {
        FachadaNegocio FNegocio = new FachadaNegocio();

        // GET: Compania
        public ActionResult Index()
        {
            return View();
        }

        // GET: Compania/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Compania/Create
        [HttpPost]
        public ActionResult Create(Entidades.Compania ObjCompania)
        {
            try
            {
                bool IsOk = false;
                FNegocio = new FachadaNegocio();
                ObjCompania.Estado = true;
                IsOk = FNegocio.AddCompania(ObjCompania);

                return RedirectToAction("LstCompania");
            }
            catch (Exception)
            {
                throw;
            }
        }

        // GET: Compania/Edit/5
        public ActionResult Edit(int id)
        {
            Entidades.Compania ObjEmpleado = new Entidades.Compania();
            FNegocio = new FachadaNegocio();
            ObjEmpleado = FNegocio.GetCompaniaById(id);
            return View(ObjEmpleado);
        }

        // POST: Compania/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Entidades.Compania ObjCompania)
        {
            try
            {
                bool IsOK = false;
                FNegocio = new FachadaNegocio();
                IsOK = FNegocio.UpdateCompania(ObjCompania);
                return RedirectToAction("LstCompania");
            }
            catch(Exception Ex)
            {
                return View();
            }
        }

        // POST: Compania/Delete/5
        
        public ActionResult Inactivar(int id)
        {
            try
            {
                bool IsOK = false;
                FNegocio = new FachadaNegocio();
                IsOK = FNegocio.InactivarCompania(id);
                return RedirectToAction("LstCompania");
            }
            catch (Exception Ex)
            {
                return View();
            }
        }

        public ActionResult LstCompania()
        {
            List<Entidades.Compania> Lst = new List<Entidades.Compania>();
            FNegocio = new FachadaNegocio();
            Lst = FNegocio.LstCompania();
            return View("LstCompania", Lst);
        }

        public PartialViewResult ddlLstCompania()
        {
            List<Entidades.Compania> Lst = new List<Entidades.Compania>();
            try
            {   
                FNegocio = new FachadaNegocio();
                Lst = FNegocio.LstCompania();
                return PartialView("ddlLstCompania", Lst);
            }
            catch (Exception Ex)
            {
                return PartialView("ddlLstCompania", Lst);
            }
        }



    }
}
