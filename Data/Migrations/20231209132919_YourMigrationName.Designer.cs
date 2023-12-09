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
    [Migration("20231209132919_YourMigrationName")]
    partial class YourMigrationName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LojaAmigurumi.Models.Pattern", b =>
                {
                    b.Property<int>("PatternId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatternId"));

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

                    b.HasKey("PatternId");

                    b.ToTable("Pattern");
                });
#pragma warning restore 612, 618
        }
    }
}
