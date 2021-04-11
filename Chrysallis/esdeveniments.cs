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
    
    public partial class esdeveniments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public esdeveniments()
        {
            this.assistir = new HashSet<assistir>();
            this.documents = new HashSet<documents>();
            this.valoracions = new HashSet<valoracions>();
            this.socis = new HashSet<socis>();
        }
    
        public int id { get; set; }
        public string titol { get; set; }
        public string descripcio { get; set; }
        public System.DateTime data { get; set; }
        public System.TimeSpan hora { get; set; }
        public string adreca { get; set; }
        public int id_comunitat { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public Nullable<int> quantitat_max { get; set; }
        public Nullable<int> quantitat_mínima { get; set; }
        public Nullable<double> preu { get; set; }
        public bool pagament { get; set; }
        public Nullable<System.DateTime> data_max { get; set; }
        public Nullable<int> cont_assitents { get; set; }
        public string meet { get; set; }
        public Nullable<int> id_localidad { get; set; }
        public Nullable<System.TimeSpan> hora_max { get; set; }
        public byte[] imatge { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assistir> assistir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documents> documents { get; set; }
        public virtual localitats localitats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<valoracions> valoracions { get; set; }
        public virtual comunitats comunitats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<socis> socis { get; set; }
    }
}
