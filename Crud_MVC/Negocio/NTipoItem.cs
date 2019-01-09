using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NTipoItem
    {
        internal List<Entidades.TipoItem> LstTipoItem()
        {
            return FachadaPersistencia.Instancia.LstTipoItem();
        }
    }
}
