using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;

namespace Negocio
{
    public class clsSocios
    {
        public List<vSociosActivos> ListarSociosActivos()
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                //BD.Socio.Include("Localidad").ToList();
                return BD.vSociosActivos.ToList();
            }
        }

        public List<vSociosActivos> ListarSocActXNomYApe(string NomYApe)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                //BD.Socio.Include("Localidad").ToList();
                return BD.vSociosActivos.Where(b => b.NomYApe.Contains(NomYApe)).ToList();
            }
        }


        public List<Socio> Listar()
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                return BD.Socio.ToList();
            }
        }

        public List<Socio> ListarXDNI(int dni)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {   
                return BD.Socio.Where(b => b.DNI == dni).ToList();
            }
        }

        public List<vListarXNomYApe> ListarXNomYApe(string NomYApe)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                //BD.Socio.Include("Localidad").ToList();
                return BD.vListarXNomYApe.Where(b => b.NomYApe.Contains(NomYApe)).ToList();
            }
        }

        public List<Socio> ListarXID(Int64 ID)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                BD.Socio.Include("Localidad").ToList();
                return BD.Socio.Where(b => b.IDSocio == ID).ToList();
            }
        }

        public int CrearModificar(Socio socio)
        {

            if (socio.IDSocio == 0)
                return insert(socio);
            else
                return update(socio);
        }

        private int insert(Socio socio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                bd.Socio.AddObject(socio);
                return bd.SaveChanges();
            } 
        }

        private int update(Socio socio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                Socio soc = bd.Socio.SingleOrDefault(b => b.IDSocio == socio.IDSocio);

                if (soc != null)
                {
                    bd.Socio.Attach(soc);
                    bd.ApplyCurrentValues("Socio", socio);

                    return bd.SaveChanges();
                }
                else
                    return 0;
            }
        }

        public Socio select(Int64 idSocio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                return bd.Socio.FirstOrDefault(x => x.IDSocio == idSocio);
            }
        }
        
        public int Eliminar(Socio socio)
        {
            using (BDClubSociosEntities bd = new BDClubSociosEntities())
            {
                Socio s = bd.Socio.SingleOrDefault(b => b.IDSocio == socio.IDSocio);
                if (s != null)
                {
                    bd.Socio.DeleteObject(s);
                    return bd.SaveChanges();
                }
                else
                    return 0;                
            }
        }
    }
}
