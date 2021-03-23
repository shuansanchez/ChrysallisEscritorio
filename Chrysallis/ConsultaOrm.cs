
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Chrysallis
{
   public static class ConsultaOrm
    {
        
        //COMUNITATS
          public static List<comunitats> SelectComunidades()
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
        public static void InsertEvento(esdeveniments _evento)
        {
            Orm.bdconnection.esdeveniments.Add(_evento);
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

        public static void DeleteEvento(esdeveniments _evento)
        {
            Orm.bdconnection.esdeveniments.Remove(_evento);
            Orm.bdconnection.SaveChanges();
        }

        public static void UpdateEvento(esdeveniments _evento)
        {
            Orm.bdconnection.SaveChanges();
        }


        //USUARIS
        public static void InsertUsuario(usuaris usuari)
        {
            Orm.bdconnection.usuaris.Add(usuari);
            Orm.bdconnection.SaveChanges();
        }

        public static List<usuaris> SelectUsuarios()
        {
            List<usuaris> _usuarios =
             (
                 from c in Orm.bdconnection.usuaris
                 select c
             ).ToList();
            return _usuarios;
        }

        //SOCIOS
        public static void InsertSocio(socis socio)
        {
            Orm.bdconnection.socis.Add(socio);
            Orm.bdconnection.SaveChanges();
        }

        public static List<socis> SelectSocios()
        {
            List<socis> _socios =
             (
                 from c in Orm.bdconnection.socis
                 select c
             ).ToList();
            return _socios;
        }

        public static void DeleteSocio(socis _socio)
        {
            Orm.bdconnection.socis.Remove(_socio);
            Orm.bdconnection.SaveChanges();
        }

        public static void UpdateSocio(socis _socio)
        {
            Orm.bdconnection.SaveChanges();
        }

    }
}
