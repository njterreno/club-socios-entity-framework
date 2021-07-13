using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsCuotaXSocio
    {
        public List<CuotaXSocio> ListarXIDSoc(Int64 IDSocio)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                return BD.CuotaXSocio.Where(b => b.IDSocio == IDSocio).ToList();
            }
        }

        public List<CuotaXSocio> ListarXIDCuotaXSoc(Int64 IDCuotaXSocio)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                return BD.CuotaXSocio.Where(b => b.IDCuotaXSocio == IDCuotaXSocio).ToList();
            }
        }

        public int GenerarCuota(CuotaXSocio cuotaXSocio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                bd.spGenCuota(cuotaXSocio.IDSocio, cuotaXSocio.MesCuota, cuotaXSocio.AñoCuota);
                return bd.SaveChanges();
            }
        }

        public int Pago(CuotaXSocio cuotaXSocio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                CuotaXSocio CxS = bd.CuotaXSocio.SingleOrDefault(b => b.IDCuotaXSocio == cuotaXSocio.IDCuotaXSocio);

                if (CxS != null)
                {
                    //bd.CuotaXSocio.Attach(CxS);
                    //bd.ApplyCurrentValues("CuotaXSocio", cuotaXSocio);

                    CxS.IDCuotaXSocio = cuotaXSocio.IDCuotaXSocio;
                    CxS.IDSocio = cuotaXSocio.IDSocio;
                    CxS.MontoTotal = cuotaXSocio.MontoTotal;
                    CxS.MontoPendiente = cuotaXSocio.MontoPendiente;
                    CxS.Cancelado = 1;

                    //CxS.Cancelado = 1;
                    //CxS.MontoPendiente = 0;
                    //CxS.MontoTotal = cuotaXSocio.MontoTotal;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public int Anular(CuotaXSocio cuotaXSocio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                CuotaXSocio CxS = bd.CuotaXSocio.SingleOrDefault(b => b.IDCuotaXSocio == cuotaXSocio.IDCuotaXSocio);

                if (CxS != null)
                {
                    CxS.Anulado = 1;
                    CxS.MontoPendiente = 0;
                    CxS.MontoTotal = 0;

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }

        //public int AnularCuota(ActividadXSocio ActXSoc)
        //{
        //    //Solo poner anulado en 1
        //    using (BDClubSociosEntities bd = new BDClubSociosEntities())
        //    {
        //        bd.spAltaSocio(ActXSoc.IDActividad, ActXSoc.IDSocio);
        //        return bd.SaveChanges();
        //    }
        //}
    }
}
