using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class AsesorController : Controller
    {
        FachadaNegocio FNegocio;

        public PartialViewResult ddlLstAsesor()
        {
            List<Entidades.Asesor> Lst = new List<Entidades.Asesor>();
            try
            {
                FNegocio = new FachadaNegocio();
                Lst = FNegocio.LstAsesor();
                return PartialView("_ddlAsesor", Lst);
            }
            catch (Exception Ex)
            {
                return PartialView("_ddlAsesor", Lst);
            }
        }
    }
}