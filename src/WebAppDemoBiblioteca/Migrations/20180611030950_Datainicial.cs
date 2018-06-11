using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppDemoBiblioteca.Migrations
{
    public partial class Datainicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriaLibros",
                columns: table => new
                {
                    CodigoCatLibro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DescripcionCatLibro = table.Column<string>(nullable: true),
                    NombreCatLibro = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaLibros", x => x.CodigoCatLibro);
                });

            migrationBuilder.CreateTable(
                name: "NivUsuarios",
                columns: table => new
                {
                    CodigoNivel = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreNivel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivUsuarios", x => x.CodigoNivel);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    CodigoLibro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatLibrosCodigoCatLibro = table.Column<int>(nullable: true),
                    CodigoCategoria = table.Column<int>(nullable: false),
                    DescripCortaLibro = table.Column<string>(nullable: true),
                    DescripLargaLibro = table.Column<string>(nullable: true),
                    DescripLibro = table.Column<string>(nullable: true),
                    EstadoLibro = table.Column<bool>(nullable: false),
                    ImagenPreviaURL = table.Column<string>(nullable: true),
                    ImagenURL = table.Column<string>(nullable: true),
                    LibroDestacado = table.Column<bool>(nullable: false),
                    LibroEnExistencia = table.Column<bool>(nullable: false),
                    NombreLibro = table.Column<string>(nullable: true),
                    PreCostoLibro = table.Column<decimal>(nullable: false),
                    PreVentaLibro = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.CodigoLibro);
                    table.ForeignKey(
                        name: "FK_Libros_CategoriaLibros_CatLibrosCodigoCatLibro",
                        column: x => x.CatLibrosCodigoCatLibro,
                        principalTable: "CategoriaLibros",
                        principalColumn: "CodigoCatLibro",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    CodigoUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CodigoNivel = table.Column<int>(nullable: false),
                    DireccionUsuario = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    EstadoUsuario = table.Column<string>(nullable: true),
                    NombreUsuario = table.Column<string>(nullable: true),
                    UsernameUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.CodigoUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_NivUsuarios_CodigoNivel",
                        column: x => x.CodigoNivel,
                        principalTable: "NivUsuarios",
                        principalColumn: "CodigoNivel",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_CatLibrosCodigoCatLibro",
                table: "Libros",
                column: "CatLibrosCodigoCatLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_CodigoNivel",
                table: "Usuarios",
                column: "CodigoNivel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CategoriaLibros");

            migrationBuilder.DropTable(
                name: "NivUsuarios");
        }
    }
}
