
using System.Collections.Generic;
using System.Linq;

namespace Chrysallis
{
   public static class ConsultaOrm
    {
        
        //COMUNITATS
          public static List<comunitats> Select()
        {
            List<comunitats> _comunidades =
            (
                from c in Orm.bdconnection.comunitats 
                select c
            ).ToList();
            return _comunidades;
        }

        //PROVINCIES
        public static List<provincies> SelectProvincias(int id)
        {
            List<provincies> _provincies =
            (
                from c in Orm.bdconnection.provincies 
                where c.id_comunitat == id 
                select c
            ).ToList();
            return _provincies;
        }


        //ESDEVENIMENTS
        public static void Insert(esdeveniments evento)
        {
            Orm.bdconnection.esdeveniments.Add(evento);
            Orm.bdconnection.SaveChanges();
        }

        public static List<esdeveniments> SelectEventos()
        {
            List<esdeveniments> _eventos =
             (
                 from c in Orm.bdconnection.esdeveniments
                 select c
             ).ToList();
            return _eventos;
        }


    }
}
