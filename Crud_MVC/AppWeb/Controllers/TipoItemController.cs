using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppWeb.Controllers
{
    public class TipoItemController : Controller
    {
        FachadaNegocio FNegocio;

        public PartialViewResult ddlLstTipoItem()
        {
            List<Entidades.TipoItem> Lst = new List<Entidades.TipoItem>();
            try
            {
                FNegocio = new FachadaNegocio();
                Lst = FNegocio.LstTipoItem();
                return PartialView("_ddlLstTipoItem", Lst);
            }
            catch (Exception Ex)
            {
                return PartialView("_ddlLstTipoItem", Lst);
            }
        }
    }
}