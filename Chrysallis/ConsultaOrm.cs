
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Chrysallis
{
   public static class ConsultaOrm
    {
        
        //COMUNIDADES
          public static List<comunitats> SelectComunidades()
        {
            List<comunitats> _comunidades =
            (
                from c in Orm.bdconnection.comunitats 
                select c
            ).ToList();
            return _comunidades;
        }

        public static List<string> SelectComunidadesNombres()
        {
            List<string> _comunidades =
            (
                from c in Orm.bdconnection.comunitats
                select c.nom
            ).ToList();
            return _comunidades;
        }

        //PROVINCIAS
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


        //EVENTOS
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


        //USUARIOS
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

        public static usuaris SelectUsuariosSocios(socis _modificaSocio)
        {
            usuaris _usuarioSocio =
             (
                 from c in Orm.bdconnection.usuaris
                 where _modificaSocio.id==c.id
                 select c
             ).FirstOrDefault();
            return _usuarioSocio;
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

        public static void UpdateSocio()
        {
            Orm.bdconnection.SaveChanges();
        }

        //MENORES
        public static void InsertMenor(menors menor)
        {
            Orm.bdconnection.menors.Add(menor);
            Orm.bdconnection.SaveChanges();
        }

        public static void InsertRelacionMenor(int idSocio, int idMenor, string relacionMenor)
        {
           // menors_socis men = new menors_socis(idSocio, idMenor, relacionMenor);
          //  Orm.bdconnection.menors_socis.Add(men);
            Orm.bdconnection.SaveChanges();

        }

        public static int SelectIDSocio(string dniSocio)
        {

           int _id =
                (
                    from c in Orm.bdconnection.socis
                    where c.dni==dniSocio
                    select c.id).First();
            return _id;

        }


        //ROLES

        public static List<string> SelectRoles()
        {
            List<string> _roles =
             (
                 from c in Orm.bdconnection.rols
                 select c.nom
             ).ToList();
            return _roles;
        }

        //VALORACIONES
        public static List<valoracions> SelectValoracionesEvento(esdeveniments _evento)
        {
            List<valoracions> _valoraciones =
             (
                 from c in Orm.bdconnection.valoracions
                 where _evento.id==c.id_esdeveniment
                 select c
             ).ToList();
            return _valoraciones;
        }

        public static List<valoracions> SelectValoracionesSocio(socis _socio)
        {
            List<valoracions> _valoraciones =
             (
                 from c in Orm.bdconnection.valoracions
                 where _socio.id == c.id_soci
                 select c
             ).ToList();
            return _valoraciones;
        }

        public static List<valoracions> SelectValoraciones()
        {
            List<valoracions> _valoraciones =
             (
                 from c in Orm.bdconnection.valoracions
                 select c
             ).ToList();
            return _valoraciones;
        }

    }
}
