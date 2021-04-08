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
    
    public partial class socis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public socis()
        {
            this.assistir = new HashSet<assistir>();
            this.menors_socis = new HashSet<menors_socis>();
            this.usuaris = new HashSet<usuaris>();
            this.valoracions = new HashSet<valoracions>();
            this.comunitats = new HashSet<comunitats>();
            this.esdeveniments = new HashSet<esdeveniments>();
        }
    
        public int id { get; set; }
        public int num { get; set; }
        public string nom { get; set; }
        public string cognoms { get; set; }
        public bool actiu { get; set; }
        public string telefon1 { get; set; }
        public string telefon2 { get; set; }
        public string email { get; set; }
        public string dni { get; set; }
        public string contrasenya { get; set; }
        public Nullable<System.DateTime> data_naixement { get; set; }
        public Nullable<System.DateTime> data_baixa { get; set; }
        public System.DateTime data_alta { get; set; }
        public bool permis_app { get; set; }
        public string codi_postal { get; set; }
        public int id_localitat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assistir> assistir { get; set; }
        public virtual localitats localitats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<menors_socis> menors_socis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuaris> usuaris { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<valoracions> valoracions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comunitats> comunitats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<esdeveniments> esdeveniments { get; set; }
    }
}
