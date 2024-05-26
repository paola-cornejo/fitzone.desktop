﻿// <auto-generated />
using Fitzone.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fitzone.EF.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240524210103_Agregar-socios-migrations")]
    partial class Agregarsociosmigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fitzone.Entidades.Socio", b =>
                {
                    b.Property<int>("idSocio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSocio"));

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("calleNumero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idBarrio")
                        .HasColumnType("int");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipoDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idSocio");

                    b.ToTable("Socio");
                });
#pragma warning restore 612, 618
        }
    }
}
