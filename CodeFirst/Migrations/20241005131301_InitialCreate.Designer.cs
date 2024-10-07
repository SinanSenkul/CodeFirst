﻿// <auto-generated />

using CodeFirst.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;

#nullable disable

namespace CodeFirst.Migrations
{
    [DbContext(typeof(PatikaFirstDbContext))]
    [Migration("20241005131301_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Code_First_Basic.Entities.Game", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Platform")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Rating")
                    .HasColumnType("decimal(18,2)");

                b.HasKey("Id");

                b.ToTable("Games", (string)null);
            });

            modelBuilder.Entity("Code_First_Basic.Entities.Movie", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Genre")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("ReleaseYear")
                    .HasColumnType("int");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Movies", (string)null);
            });
#pragma warning restore 612, 618
        }
    }
}