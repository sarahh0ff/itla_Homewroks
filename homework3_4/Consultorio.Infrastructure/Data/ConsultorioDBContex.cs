using Consultorio.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace DenounceBeasts.Dbcontext
{
    public class ConsultorioDbContex:DbContext
    {
        public ConsultorioDbContex(DbContextOptions<ConsultorioDbContex> options) : base(options)
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
