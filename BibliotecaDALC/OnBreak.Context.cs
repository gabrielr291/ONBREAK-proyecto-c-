﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaDALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnBreakEntities : DbContext
    {
        public OnBreakEntities()
            : base("name=OnBreakEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ActividadEmpresa> ActividadEmpresa { get; set; }
        public DbSet<Cenas> Cenas { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Cocktail> Cocktail { get; set; }
        public DbSet<CoffeeBreak> CoffeeBreak { get; set; }
        public DbSet<Contrato> Contrato { get; set; }
        public DbSet<ModalidadServicio> ModalidadServicio { get; set; }
        public DbSet<TipoAmbientacion> TipoAmbientacion { get; set; }
        public DbSet<TipoEmpresa> TipoEmpresa { get; set; }
        public DbSet<TipoEvento> TipoEvento { get; set; }
    }
}
