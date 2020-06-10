using Microsoft.EntityFrameworkCore;
using PlasticosFortuna.Shared;
using System;

namespace PlasticosFortuna.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ItemOrdenTrabajo> ItemsOrdenTrabajo { get; set; }
        public DbSet<Operacion> Operaciones { get; set; }
        public DbSet<OrdenDeTrabajo> OrdenesDeTrabajo { get; set; }
        public DbSet<Plastico> Plasticos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<UserModel> UserModel { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Cliente>().HasData(new Cliente { Id = 1, Nombre = "Maxiconsumo S.A", Descripcion = "Test abc abc abc abc" });
            modelBuilder.Entity<Cliente>().HasData(new Cliente { Id = 2, Nombre = "RobSanchez S.A", Descripcion = "Test 123 123 123 123" });
        }

    }
}
