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



    }
}
