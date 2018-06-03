using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppDemoBiblioteca.models;

namespace WebAppDemoBiblioteca.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20180603035719_Datainiciousuarios")]
    partial class Datainiciousuarios
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppDemoBiblioteca.models.usuarios.NivelesUsuario", b =>
                {
                    b.Property<int>("CodigoNivel")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreNivel");

                    b.HasKey("CodigoNivel");

                    b.ToTable("NivUsuarios");
                });

            modelBuilder.Entity("WebAppDemoBiblioteca.models.usuarios.usuarios", b =>
                {
                    b.Property<int>("CodigoUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodigoNivel");

                    b.Property<string>("DireccionUsuario");

                    b.Property<string>("EstadoUsuario");

                    b.Property<string>("ImagenURL");

                    b.Property<string>("ImagenUsuarioURL");

                    b.Property<string>("NombreUsuario");

                    b.Property<string>("UsernameUsuario");

                    b.HasKey("CodigoUsuario");

                    b.HasIndex("CodigoNivel");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebAppDemoBiblioteca.models.usuarios.usuarios", b =>
                {
                    b.HasOne("WebAppDemoBiblioteca.models.usuarios.NivelesUsuario", "NivUsuarios")
                        .WithMany("Usuarios")
                        .HasForeignKey("CodigoNivel")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
