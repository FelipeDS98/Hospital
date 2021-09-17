using HospiEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Enfermera> Enfermeras { get; set; }

        public DbSet<FamiliarDesignado> FamiliaresDesignados { get; set; }

        public DbSet<Historia> Historias { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Paciente> Pacientes { get; set; }

        public DbSet<SignoVital> SignosVitales { get; set; }

        public DbSet<SugerenciaCuidado> SugerenciasCuidado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=FELIPE;Database=Hospital;User ID=FELIPE;Password=123;Trusted_Connection=false;MultipleActiveResultSets=true");
            }

        }
    }
}