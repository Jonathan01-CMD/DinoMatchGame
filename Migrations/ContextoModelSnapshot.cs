﻿// <auto-generated />
using DinoMatchGame.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DinoMatchGame.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("DinoMatchGame.Models.MatchDino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dificultad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Jugador")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModoDeJuego")
                        .HasColumnType("TEXT");

                    b.Property<double>("TiempoJugada")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("MatchDino");
                });

            modelBuilder.Entity("DinoMatchGame.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MejorPuntuación")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreCompleto")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreDeUsuario")
                        .HasColumnType("TEXT");

                    b.Property<int>("VecesJugado")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.ToTable("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
