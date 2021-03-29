
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Chrysallis
{
   public static class ConsultaOrm
    {
        
        //COMUNIDADES-----------------------------------------------------
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

        //PROVINCIAS------------------------------------------------------
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


        //EVENTOS---------------------------------------------------------
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

        //USUARIOS--------------------------------------------------------
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

        //SOCIOS----------------------------------------------------------
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

        public static socis SelectSocio(socis socio)
        {
            socis _socio =
             (
                 from c in Orm.bdconnection.socis
                 where socio.id == c.id
                 select c
             ).FirstOrDefault();
            return _socio;
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

        //ROLES-----------------------------------------------------------
        public static List<string> SelectRoles()
        {
            List<string> _roles =
             (
                 from c in Orm.bdconnection.rols
                 select c.nom
             ).ToList();
            return _roles;
        }

        //VALORACIONES----------------------------------------------------
        public static List<valoracions> SelectValoracionesEvento(esdeveniments _evento)
        {
            List<valoracions> _valoraciones =
             (
                 from c in Orm.bdconnection.valoracions
                 where _evento.id == c.id_esdeveniment
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

        public static void DeleteValoracion(valoracions _valoracion)
        {
            Orm.bdconnection.valoracions.Remove(_valoracion);
            Orm.bdconnection.SaveChanges();
        }

        //MENORES---------------------------------------------------------
        public static List<menors> SelectMenores()
        {
            List<menors> _menores =
             (
                 from c in Orm.bdconnection.menors
                 select c
             ).ToList();
            return _menores;
        }

        public static List<menors> SelectRelacionMenor(menors_socis _relacion)
        {
            List<menors> _menores =
             (
                 from c in Orm.bdconnection.menors
                 where _relacion.id_menor == c.id
                 select c
             ).ToList();
            return _menores;
        }

        public static List<menors> SelectMenoresDeSocio(socis _socio)
        {
            List<menors> _menores =
             (
                 from c in Orm.bdconnection.menors
                 where _socio.id == c.id
                 select c
             ).ToList();
            return _menores;
        } //PASO 1 SOCIS-MENORS

        public static void InsertMenor(menors menor)
        {
            Orm.bdconnection.menors.Add(menor);
            Orm.bdconnection.SaveChanges();
        }

        public static void DeleteMenor(menors _menor)
        {
            Orm.bdconnection.menors.Remove(_menor);
            Orm.bdconnection.SaveChanges();
        }

        //SOCIOS_MENORES--------------------------------------------------

        public static List<menors_socis> SelectRelacionesSocio(socis _socio)
        {
            List<menors_socis> _menores =
             (
                 from c in Orm.bdconnection.menors_socis
                 where _socio.id == c.id_soci
                 select c
             ).ToList();
            return _menores;
        }

        public static menors SelectRelacionSocio(menors_socis _menorsocio)
        {
            menors _menores =
             (
                 from c in Orm.bdconnection.menors
                 where c.id == _menorsocio.id_menor
                 select c
             ).FirstOrDefault() ;
            return _menores;
        }

        public static void InsertRelacion(menors_socis relacio)
        {
            Orm.bdconnection.menors_socis.Add(relacio);
            Orm.bdconnection.SaveChanges();
        }

        public static void DeleteRelacion(menors_socis _relacion)
        {
            Orm.bdconnection.menors_socis.Remove(_relacion);
            Orm.bdconnection.SaveChanges();
        }

        //DOCUMENTOS------------------------------------------------------

        public static List<documents> SelectDocumentoEvento(esdeveniments _evento)
        {
            List<documents> _documento =
             (
                 from c in Orm.bdconnection.documents
                 where _evento.id==c.id_esdeveniment
                 select c
             ).ToList();
            return _documento;
        }

        public static void InsertDocumento(documents _documento)
        {
            Orm.bdconnection.documents.Add(_documento);
            Orm.bdconnection.SaveChanges();
        }

        public static void DeleteDocumento(documents _documento)
        {
            Orm.bdconnection.documents.Remove(_documento);
            Orm.bdconnection.SaveChanges();
        }
    }
}
