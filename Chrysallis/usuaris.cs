//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chrysallis
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuaris
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuaris()
        {
            this.comunitats = new HashSet<comunitats>();
        }
    
        public int id { get; set; }
        public string contrasenya { get; set; }
        public int id_rol { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Nullable<int> id_socio { get; set; }
        public bool actiu { get; set; }
    
        public virtual rols rols { get; set; }
        public virtual socis socis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comunitats> comunitats { get; set; }
    }
}
