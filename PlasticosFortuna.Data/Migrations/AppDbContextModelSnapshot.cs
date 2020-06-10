﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlasticosFortuna.Data;

namespace PlasticosFortuna.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlasticosFortuna.Shared.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Test abc abc abc abc",
                            Nombre = "Maxiconsumo S.A"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Test 123 123 123 123",
                            Nombre = "RobSanchez S.A"
                        });
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.ItemOrdenTrabajo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ancho")
                        .HasColumnType("int");

                    b.Property<int>("CantidadDeBobinas")
                        .HasColumnType("int");

                    b.Property<int>("Espesor")
                        .HasColumnType("int");

                    b.Property<int>("Largo")
                        .HasColumnType("int");

                    b.Property<int?>("OrdenDeTrabajoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoPlastico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrdenDeTrabajoId");

                    b.ToTable("ItemsOrdenTrabajo");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.Operacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaOperacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PlasticoId")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.Property<int>("TipoOperacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlasticoId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Operaciones");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.OrdenDeTrabajo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BobinaProducto")
                        .HasColumnType("bit");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<bool>("NecesitaImpresion")
                        .HasColumnType("bit");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("OrdenesDeTrabajo");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.Plastico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadTotal")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Plasticos");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.UserModel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRoleRoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("UserRoleRoleId");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.ItemOrdenTrabajo", b =>
                {
                    b.HasOne("PlasticosFortuna.Shared.OrdenDeTrabajo", "OrdenDeTrabajo")
                        .WithMany("Items")
                        .HasForeignKey("OrdenDeTrabajoId");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.Operacion", b =>
                {
                    b.HasOne("PlasticosFortuna.Shared.Plastico", "Plastico")
                        .WithMany("Operaciones")
                        .HasForeignKey("PlasticoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlasticosFortuna.Shared.Proveedor", "Proveedor")
                        .WithMany("Operaciones")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.OrdenDeTrabajo", b =>
                {
                    b.HasOne("PlasticosFortuna.Shared.Cliente", "Cliente")
                        .WithMany("OrdenesDeTrabajo")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("PlasticosFortuna.Shared.UserModel", b =>
                {
                    b.HasOne("PlasticosFortuna.Shared.UserRole", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleRoleId");
                });
#pragma warning restore 612, 618
        }
    }
}
