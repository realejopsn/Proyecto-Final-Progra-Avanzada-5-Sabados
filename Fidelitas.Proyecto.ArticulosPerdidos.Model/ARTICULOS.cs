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
    [DataContract] public partial class ARTICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULOS()
        {
            this.PERSONA_ENTREGANDO = new HashSet<PERSONA_ENTREGANDO>();
            this.PERSONA_REPORTANDO_EXTRAVIO = new HashSet<PERSONA_REPORTANDO_EXTRAVIO>();
        }
    
        [DataMember] public int ID { get; set; }
        [DataMember] public Nullable<int> ID_CATEGORIA { get; set; }
        [DataMember] public Nullable<int> ESTADO { get; set; }
        [DataMember] public string MARCA { get; set; }
        [DataMember] public string MODELO { get; set; }
        [DataMember] public string DESCRIPCION { get; set; }
        [DataMember] public string FOTOS { get; set; }
    
        public virtual CATEGORIA_ARTICULO CATEGORIA_ARTICULO { get; set; }
        public virtual ESTADOS ESTADOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONA_ENTREGANDO> PERSONA_ENTREGANDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONA_REPORTANDO_EXTRAVIO> PERSONA_REPORTANDO_EXTRAVIO { get; set; }
    }
}
