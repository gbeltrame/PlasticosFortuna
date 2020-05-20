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

    }
}
