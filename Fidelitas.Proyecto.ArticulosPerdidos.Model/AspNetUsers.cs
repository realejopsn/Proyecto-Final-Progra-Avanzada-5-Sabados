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
    [DataContract] public partial class AspNetUsers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUsers()
        {
            this.AspNetUserClaims = new HashSet<AspNetUserClaims>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogins>();
            this.AspNetRoles = new HashSet<AspNetRoles>();
        }
    
        [DataMember] public string Id { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public bool EmailConfirmed { get; set; }
        [DataMember] public string PasswordHash { get; set; }
        [DataMember] public string SecurityStamp { get; set; }
        [DataMember] public string PhoneNumber { get; set; }
        [DataMember] public bool PhoneNumberConfirmed { get; set; }
        [DataMember] public bool TwoFactorEnabled { get; set; }
        [DataMember] public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        [DataMember] public bool LockoutEnabled { get; set; }
        [DataMember] public int AccessFailedCount { get; set; }
        [DataMember] public string UserName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetRoles> AspNetRoles { get; set; }
    }
}
