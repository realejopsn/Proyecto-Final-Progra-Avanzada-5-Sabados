﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fidelitas.Proyecto.ArticulosPerdidos.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProyectoProgra5Entities : DbContext
    {
        public ProyectoProgra5Entities()
            : base("name=ProyectoProgra5Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ARTICULOS> ARTICULOS { get; set; }
        public virtual DbSet<CATEGORIA_ARTICULO> CATEGORIA_ARTICULO { get; set; }
        public virtual DbSet<PERSONA> PERSONA { get; set; }
        public virtual DbSet<PERSONA_ENTREGANDO> PERSONA_ENTREGANDO { get; set; }
        public virtual DbSet<PERSONA_REPORTANDO_EXTRAVIO> PERSONA_REPORTANDO_EXTRAVIO { get; set; }
    }
}
