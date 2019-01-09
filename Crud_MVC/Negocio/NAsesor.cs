using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAsesor
    {
        internal List<Entidades.Asesor> LstAsesor()
        {
            return FachadaPersistencia.Instancia.LstAsesor();
        }
    }
}
