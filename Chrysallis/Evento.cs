using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrysallis
{
    class Evento : IEquatable<Evento>
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; } 
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public String direccion { get; set; }

        /* https://www.latlong.net/convert-address-to-lat-long.html */
        public String latitud { get; set; }
        public String longitud { get; set; }
        public Boolean requierePago { get; set; }
        public int max_personas { get; set; }
        public int min_personas { get; set; }
        public int contador_asistentes { get; set; }
        public String enlaceMeet { get; set; }
        public String rutaImagen { get; set; }
        public int imagen { get; set; }

        public bool Equals(Evento check)
        {
            Boolean equal = false;

            if (this.nombre.Equals(check.nombre) && this.rutaImagen.Equals(check.rutaImagen))
            {
                equal = true;
            }

            return equal;
        }
    }
}
