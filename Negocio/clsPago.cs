using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsPago
    {
        public List<Pago> ListarXIDCxS(Int64 IDCuotaXSocio)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                return BD.Pago.Where(b => b.IDCuotaXSocio == IDCuotaXSocio).ToList();
            }
        }

        public int Pago(Pago pago)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                bd.Pago.AddObject(pago);

                return bd.SaveChanges();
            }
        }

        public int ActPago(Pago pago)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                Pago P = bd.Pago.SingleOrDefault(b => b.IDPago == pago.IDPago);

                if (P != null)
                {  
                    P.Monto = pago.Monto;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }
    }
}
