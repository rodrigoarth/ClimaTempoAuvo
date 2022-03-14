
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ClimaTempo.Models
{
    public class ClimaTempoContext : DbContext
    {
        public ClimaTempoContext() : base("ClimaTempoConnection") 
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ClimaTempoContext>());
        }

        public DbSet<PrevisaoClima> PrevisaoClimas { get; set; }
        public DbSet<Estado> Estados { get; set;}
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}