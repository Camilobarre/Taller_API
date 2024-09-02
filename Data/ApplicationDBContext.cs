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
        public DbSet<Propietario> Propietarios{ get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}