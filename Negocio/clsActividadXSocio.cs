using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public partial class clsActividadXSocio
    {
        public List<spListarSocioXAct_Result> ListaActividad(Int64 IDSocio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                return bd.spListarSocioXAct(IDSocio).ToList(); 
            }
        }

        public int AltaSocio(ActividadXSocio ActXSoc)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {   
                bd.spAltaSocio(ActXSoc.IDActividad, ActXSoc.IDSocio);
                return bd.SaveChanges();
            }
        }

        public int BajaSocio(ActividadXSocio ActXSoc)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                bd.spBajaSocio(ActXSoc.IDActividad, ActXSoc.IDSocio);
                return bd.SaveChanges();
            }
        }
    }
}
