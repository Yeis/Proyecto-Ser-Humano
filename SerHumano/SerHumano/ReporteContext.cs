using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SerHumano.Models;

namespace SerHumano
{
    public class ReporteContext: DbContext
    {
        public ReporteContext():base("ReporteContext")
        {
        }
        public DbSet<Reporte> Reportes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}