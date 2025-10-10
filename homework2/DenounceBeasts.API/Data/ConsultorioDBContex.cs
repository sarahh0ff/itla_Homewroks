using Consultorio.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace DenounceBeasts.Dbcontext
{
    public class ConsultorioDBContex:DbContext
    {
        public ConsultorioDBContex(DbContextOptions<ConsultorioDBContex> options) : base(options)
        {
        }
        public DbSet<Medico> Medicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Medico>().HasIndex(m => m.Name).IsUnique();
        }
    }
}
