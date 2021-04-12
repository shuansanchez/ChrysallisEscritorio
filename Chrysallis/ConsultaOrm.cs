
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
        public static comunitats SelectComunidad(socis user)
        {
            comunitats _comunidades =
            (
                from c in Orm.bdconnection.comunitats
                where c.id == user.id_comunidad
                select c
            ).FirstOrDefault();
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

        public static List<provincies> SelectProvinciasTodas()
        {
            List<provincies> _provincies =
            (
                from c in Orm.bdconnection.provincies
                select c
            ).ToList();
            return _provincies;
        }
        //LOCALIDADES
        public static List<localitats> SelectLocalidades(int id)
        {
            List<localitats> _localitats =
            (
                from c in Orm.bdconnection.localitats
                where c.id_provincia == id
                select c
            ).ToList();
            return _localitats;
        }

        public static List<localitats> SelectLocalidadesTodas()
        {
            List<localitats> _localitats =
            (
                from c in Orm.bdconnection.localitats
                select c
            ).ToList();
            return _localitats;
        }

        //LOCALIDADES MOSTRAR
        public static List<localitats> SelectMostrarLoc()
        {
            List<localitats> _localitats =
            (
                from c in Orm.bdconnection.localitats
                select c
            ).ToList();
            return _localitats;
        }

        //ELIMINAR LOCALIDADES
        public static void DeleteLocalidad(localitats localidad)
        {
            Orm.bdconnection.localitats.Remove(localidad);
            Orm.bdconnection.SaveChanges();
        }



        //EVENTOS---------------------------------------------------------
        public static void InsertEvento(esdeveniments _evento)
        {
            Orm.bdconnection.esdeveniments.Add(_evento);
            Orm.bdconnection.SaveChanges();
        }

        public static List<esdeveniments>SelectEsdeveniments(socis socio)
        {
            List<esdeveniments> _esde =
                (
            from c in Orm.bdconnection.esdeveniments
            where c.id_comunitat == socio.id_comunidad
            select c
            ).ToList();
            return _esde;
        }
        public static List<esdeveniments> SelectEsdevenimentstodo(socis socio)
        {
            List<esdeveniments> _esde =
                (
            from c in Orm.bdconnection.esdeveniments
            select c
            ).ToList();
            return _esde;
        }

        //LOCALIDADES
        public static void InsertLocalidad(localitats localidad)
        {
            Orm.bdconnection.localitats.Add(localidad);
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
        //buscar por nombre
        public static List<esdeveniments> SelectEventoPorNombre(string eventoEscrito)
        {
            List<esdeveniments> eventos = (from c in Orm.bdconnection.esdeveniments
                                   where c.titol.Contains(eventoEscrito)
                                   select c).ToList();

            return eventos;
        }
        //buscar por CA
        public static List<esdeveniments> SelectEventoPorCAutonoma(string CAescrita)
        {
            List<esdeveniments> eventos = (from c in Orm.bdconnection.esdeveniments
                                           where c.comunitats.nom.Contains(CAescrita)
                                           select c).ToList();

            return eventos;
        }

        public static List<esdeveniments> SelectEventoPorPrecioMayorDe(float precioFiltro)
        {
           

       

            List<esdeveniments> eventos = (from c in Orm.bdconnection.esdeveniments
                                           where c.preu.Value> precioFiltro
                                           select c).ToList();

            return eventos;
        }
        //buscar por precio menor de

        public static List<esdeveniments> SelectEventoPorPrecioMenorDe(float precioFiltro)
        {
            List<esdeveniments> eventos = (from c in Orm.bdconnection.esdeveniments
                                           where c.preu.Value <= (precioFiltro)
                                           select c).ToList();

            return eventos;
        }

      
        public static void DeleteEvento(esdeveniments _evento)
        {
            Orm.bdconnection.esdeveniments.Remove(_evento);
            Orm.bdconnection.SaveChanges();
        }

        public static void UpdateEvento()
        {
            Orm.bdconnection.SaveChanges();
        }

        //USUARIOS--------------------------------------------------------
        public static void InsertUsuario(usuaris usuari)
        {
            Orm.bdconnection.usuaris.Add(usuari);
            Orm.bdconnection.SaveChanges();
        }
        public static void DeleteUser(usuaris usuari)
        {
            Orm.bdconnection.usuaris.Remove(usuari);
            Orm.bdconnection.SaveChanges();
        }

        public static usuaris selectLogin(string user, string contra)
        {
            usuaris _usu =
                (
                from c in Orm.bdconnection.usuaris
                where c.username == user && c.contrasenya == contra
                select c
                ).FirstOrDefault();
            return _usu;
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

        public static usuaris SelectUsuarioSocio(socis _modificaSocio)
        {
            usuaris _usuarioSocio =
             (
                 from c in Orm.bdconnection.usuaris
                 where _modificaSocio.id==c.id_socio    
                 select c
             ).FirstOrDefault();
            return _usuarioSocio;
        }
        public static socis SelectSocioUser(usuaris _modificaSocio)
        {
            socis _usuarioSocio =
             (
                 from c in Orm.bdconnection.socis
                 where _modificaSocio.id_socio == c.id
                 select c
             ).FirstOrDefault();
            return _usuarioSocio;
        }
        public static socis SelectSociosAdmins(usuaris so)
        {
            socis _socios =
                (
                    from c in Orm.bdconnection.socis
                    where c.id == so.id_socio
                    select c
                ).FirstOrDefault();
            return _socios;
        }
        public static List<socis> SelectSociosComunidadUser(socis so)
        {
           List<socis> _socios =
        (
            from c in Orm.bdconnection.socis
            where c.id_comunidad == so.id_comunidad
            select c
        ).ToList();
            return _socios;
        }

        public static void UpdateUsuario(usuaris usuarioModificar)
        {
            Orm.bdconnection.SaveChanges();
        }

        //SOCIOS----------------------------------------------------------
        public static void InsertSocio(socis socio)
        {
            Orm.bdconnection.socis.Add(socio);
            Orm.bdconnection.SaveChanges();
        }
        public static socis SelectSocioIgual(socis s)
        {
            socis _socio =
                (
                    from c in Orm.bdconnection.socis
                    where c.dni == s.dni
                    select c
                ).FirstOrDefault();
            return _socio;
        }
        public static socis SelectSocioIgualMod(socis s)
        {
            socis _socio =
                (
                    from c in Orm.bdconnection.socis
                    where c.dni == s.dni && c.id != s.id
                    select c
                ).FirstOrDefault();
            return _socio;
        }

        public static socis SelectSocioIgualNumeroSMod(socis s)
        {
            socis _socio =
                (
                    from c in Orm.bdconnection.socis
                    where c.num == s.num && c.id != s.id
                    select c
                ).FirstOrDefault();
            return _socio;
        }
        public static socis SelectSocioIgualNumeroS(socis s)
        {
            socis _socio =
                (
                    from c in Orm.bdconnection.socis
                    where c.num == s.num 
                    select c
                ).FirstOrDefault();
            return _socio;
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

        public static void UpdateSocio(socis socioModificar)
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
        public static rols SelectRol(int id)
        {
            rols _rol =
             (
                 from c in Orm.bdconnection.rols
                 where c.id == id
                 select c
             ).FirstOrDefault();
            return _rol;
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
             ).FirstOrDefault();
            return _menores;
        } //PASO 2 SOCIS-MENORS

        public static menors_socis SelectRelacion(socis _socio)
        {
            menors_socis _menores =
             (
                 from c in Orm.bdconnection.menors_socis
                 where c.id_soci == _socio.id
                 select c
             ).First();
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
