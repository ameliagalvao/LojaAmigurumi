﻿// <auto-generated />
using LojaAmigurumi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LojaAmigurumi.Data.Migrations
{
    [DbContext(typeof(PatternDbContext))]
    [Migration("20231210020825_CargaInicialCategorias")]
    partial class CargaInicialCategorias
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoriaPattern", b =>
                {
                    b.Property<int>("CategoriasCategoriaId")
                        .HasColumnType("int");

                    b.Property<int>("PatternsPatternId")
                        .HasColumnType("int");

                    b.HasKey("CategoriasCategoriaId", "PatternsPatternId");

                    b.HasIndex("PatternsPatternId");

                    b.ToTable("CategoriaPattern");
                });

            modelBuilder.Entity("LojaAmigurumi.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("LojaAmigurumi.Models.Nivel", b =>
                {
                    b.Property<int>("NivelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NivelId"));

                    b.Property<string>("NivelDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NivelId");

                    b.ToTable("Nivel");
                });

            modelBuilder.Entity("LojaAmigurumi.Models.Pattern", b =>
                {
                    b.Property<int>("PatternId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatternId"));

                    b.Property<int>("NivelId")
                        .HasColumnType("int");

                    b.Property<string>("PatternDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PatternImageUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatternName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("PatternPrice")
                        .HasColumnType("float");

                    b.Property<bool>("ReceitaGratuita")
                        .HasColumnType("bit");

                    b.HasKey("PatternId");

                    b.HasIndex("NivelId");

                    b.ToTable("Pattern");
                });

            modelBuilder.Entity("CategoriaPattern", b =>
                {
                    b.HasOne("LojaAmigurumi.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasCategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LojaAmigurumi.Models.Pattern", null)
                        .WithMany()
                        .HasForeignKey("PatternsPatternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LojaAmigurumi.Models.Pattern", b =>
                {
                    b.HasOne("LojaAmigurumi.Models.Nivel", null)
                        .WithMany("Patterns")
                        .HasForeignKey("NivelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LojaAmigurumi.Models.Nivel", b =>
                {
                    b.Navigation("Patterns");
                });
#pragma warning restore 612, 618
        }
    }
}
