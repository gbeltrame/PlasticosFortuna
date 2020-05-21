using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlasticosFortuna.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plasticos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(nullable: false),
                    CantidadTotal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plasticos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesDeTrabajo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    BobinaProducto = table.Column<bool>(nullable: false),
                    NecesitaImpresion = table.Column<bool>(nullable: false),
                    ClienteId = table.Column<int>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaCreacion = table.Column<DateTime>(nullable: false),
                    FechaModificacion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesDeTrabajo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenesDeTrabajo_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Operaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoOperacion = table.Column<int>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    ProveedorId = table.Column<int>(nullable: true),
                    FechaOperacion = table.Column<DateTime>(nullable: false),
                    PlasticoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operaciones_Plasticos_PlasticoId",
                        column: x => x.PlasticoId,
                        principalTable: "Plasticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Operaciones_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemsOrdenTrabajo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPlastico = table.Column<int>(nullable: false),
                    CantidadDeBobinas = table.Column<int>(nullable: false),
                    Ancho = table.Column<int>(nullable: false),
                    Largo = table.Column<int>(nullable: false),
                    Espesor = table.Column<int>(nullable: false),
                    OrdenDeTrabajoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsOrdenTrabajo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsOrdenTrabajo_OrdenesDeTrabajo_OrdenDeTrabajoId",
                        column: x => x.OrdenDeTrabajoId,
                        principalTable: "OrdenesDeTrabajo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsOrdenTrabajo_OrdenDeTrabajoId",
                table: "ItemsOrdenTrabajo",
                column: "OrdenDeTrabajoId");

            migrationBuilder.CreateIndex(
                name: "IX_Operaciones_PlasticoId",
                table: "Operaciones",
                column: "PlasticoId");

            migrationBuilder.CreateIndex(
                name: "IX_Operaciones_ProveedorId",
                table: "Operaciones",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesDeTrabajo_ClienteId",
                table: "OrdenesDeTrabajo",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsOrdenTrabajo");

            migrationBuilder.DropTable(
                name: "Operaciones");

            migrationBuilder.DropTable(
                name: "OrdenesDeTrabajo");

            migrationBuilder.DropTable(
                name: "Plasticos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
