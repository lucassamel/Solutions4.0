﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Solutions4.Context;

namespace Solutions4.Migrations
{
    [DbContext(typeof(SolutionsContext))]
    [Migration("20210411005129_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Solutions4.Model.Patente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassificacaoIPC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoWO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplementoDespacho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataDeposito")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataEntradaNacional")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPacote")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPrioridade")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRPI")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataWO")
                        .HasColumnType("datetime2");

                    b.Property<string>("Depositante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoDespacho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Despacho")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPacote")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPedido")
                        .HasColumnType("int");

                    b.Property<int>("NumeroPrioridade")
                        .HasColumnType("int");

                    b.Property<string>("PaisPrioridade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Procurador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RPI")
                        .HasColumnType("int");

                    b.Property<string>("Regiao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patentes");
                });
#pragma warning restore 612, 618
        }
    }
}
