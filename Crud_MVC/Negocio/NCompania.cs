using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCompania
    {
        internal bool AddCompania(Entidades.Compania ObjCompania)
        {
            try
            {
                return FachadaPersistencia.Instancia.AddCompania(ObjCompania);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        internal List<Entidades.Compania> LstCompania()
        {
            try
            {
                return FachadaPersistencia.Instancia.LstCompania();
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal bool UpdateCompania(Entidades.Compania ObjCompania)
        {   
            return FachadaPersistencia.Instancia.UpdateCompania(ObjCompania);
        }

        internal Entidades.Compania GetCompaniaById(int id)
        {   
            return FachadaPersistencia.Instancia.GetCompaniaById(id);
        }

        internal bool InactivarCompania(int id)
        {
            return FachadaPersistencia.Instancia.InactivarCompania(id);
        }
    }
}
