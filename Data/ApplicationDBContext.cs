using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller.Models;

namespace Taller.Data
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>(vehiculo =>
            {
                vehiculo.ToTable("vehiculos"); // Data  Annotations de [Table("vehiculos")]
                vehiculo.HasKey(v => v.Id);
                vehiculo.Property(v => v.Id).ValueGeneratedOnAdd();
                vehiculo.Property(v => v.Marca).HasMaxLength(100).IsRequired();
                vehiculo.Property(v => v.Modelo).HasMaxLength(50).IsRequired();
                vehiculo.Property(v => v.PropietarioID).IsRequired();
                vehiculo.Property(v => v.Año).HasMaxLength(4).IsRequired();
                vehiculo.Property(v => v.Color).HasMaxLength(50).IsRequired();
                vehiculo.Property(v => v.TipoVehiculo).HasMaxLength(50).IsRequired(false); // False sirve para que una propiedad sea opcional
                vehiculo.Property(v => v.NumeroChasis).HasMaxLength(25).IsRequired();
                vehiculo.HasOne(v=>v.Propietario);
                // .WithMany(p=>p.Vehiculos)
                // .HasForeignKey(v=>v.PropietarioID);
            });
        }


    }
}