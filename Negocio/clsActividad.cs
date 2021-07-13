using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsActividad
    {
        public List<Actividad> Listar()
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                return BD.Actividad.ToList();
            }
        }
    }
}
