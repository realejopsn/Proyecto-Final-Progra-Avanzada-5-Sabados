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
    [DataContract] public partial class PERSONA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONA()
        {
            this.PERSONA_ENTREGANDO = new HashSet<PERSONA_ENTREGANDO>();
            this.PERSONA_REPORTANDO_EXTRAVIO = new HashSet<PERSONA_REPORTANDO_EXTRAVIO>();
        }
    
        [DataMember] public int ID { get; set; }
        [DataMember] public string NOMBRE_COMPLETO { get; set; }
        [DataMember] public string USUARIO { get; set; }
        [DataMember] public string PASSWORD { get; set; }
        [DataMember] public string EMAIL { get; set; }
        [DataMember] public string ROL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONA_ENTREGANDO> PERSONA_ENTREGANDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONA_REPORTANDO_EXTRAVIO> PERSONA_REPORTANDO_EXTRAVIO { get; set; }
    }
}