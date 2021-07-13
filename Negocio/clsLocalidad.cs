using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class clsLocalidad
    {
        public List<Localidad> Listar()
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                return BD.Localidad.ToList();
            }
        }

        public List<Localidad> ListarXID(Int64 ID)
        {
            using (BDClubSociosEntities BD = new BDClubSociosEntities())
            {
                return BD.Localidad.Where(b => b.IDLocalidad == ID).ToList();
            }
        }
    }

    //var lst = bd.socio.join(localidades, idloc => idloc).select(); (A ESTA NO LA VAMOS A USAR)

    //vamos a traer Socio con localidad
    //var lst = from S in db.Socio join L in db.localidad on S.IDLocalidad = L.IDLocalidad
    //Select S;

    //Para traer idsocio, nombre, apellido, direccion, nombrelocalidad

    //hacemos una clase solo con los datos que yo quiero traer
    //public class oSoc
    //{
    //    public Int64 IdSocio;
    //    public string nombre;
    //    public string apellido;
    //    public string direccion;
    //    public string localidad;
    //}

    //y hacemos esto
    ////IENUMERABLE o IQUERYABLE lst = from S in db.Socio join L in db.localidad on S.IDLocalidad = L.IDLocalidad
    ////Select new oSoc 
    //        {     idsocio = s.Idsocio,
    //              nombre = s.nombre,
    //              nombre = s.apellido,
    //              nombre = s.direccion,
    //              nombre = s.localidad
    //        }; podemos poner tolist() y devuelve una lista y en vez de devolver un ienumerable o un iqueryable 
    //          sino tenemos que poner el nombre del iqueryable o el ienumerable(lst en este caso y le ponemos tolist(), 
    //          quedaria lst.tolist y lo recorremos con un foreach)

    //traer muchos datos Iqueryabel - pocos datos IEnumerable





}
