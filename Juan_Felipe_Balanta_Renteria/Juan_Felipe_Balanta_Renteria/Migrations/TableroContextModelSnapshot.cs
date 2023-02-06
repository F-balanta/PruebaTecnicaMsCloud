﻿// <auto-generated />
using Juan_Felipe_Balanta_Renteria.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Juan_Felipe_Balanta_Renteria.Migrations
{
    [DbContext(typeof(TableroContext))]
    partial class TableroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Juan_Felipe_Balanta_Renteria.Entities.TableroEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Arranque")
                        .HasColumnType("int");

                    b.Property<int>("Envion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("TotalPeso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tablero", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Arranque = 134,
                            Envion = 177,
                            Nombre = " Carlos Alvis",
                            Pais = "AUS",
                            TotalPeso = 311
                        });
                });
#pragma warning restore 612, 618
        }
    }
}