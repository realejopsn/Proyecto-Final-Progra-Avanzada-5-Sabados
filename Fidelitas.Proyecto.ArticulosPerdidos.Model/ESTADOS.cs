//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fidelitas.Proyecto.ArticulosPerdidos.Model
{
     using System.Runtime.Serialization;using System;
    using System.Collections.Generic;
    [DataContract] public partial class ESTADOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ESTADOS()
        {
            this.ARTICULOS = new HashSet<ARTICULOS>();
        }
    
        [DataMember] public int Id_Estado { get; set; }
        [DataMember] public string Nombre_Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULOS> ARTICULOS { get; set; }
    }
}
