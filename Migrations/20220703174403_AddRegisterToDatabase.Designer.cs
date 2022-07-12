﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentaCar.Data;

#nullable disable

namespace RentaCar.Migrations
{
    [DbContext(typeof(DbCar))]
    [Migration("20220703174403_AddRegisterToDatabase")]
    partial class AddRegisterToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RentaCar.Models.Automobili", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameofImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("day4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("doors")
                        .HasColumnType("int");

                    b.Property<string>("engine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gasoline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gearbox")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("passengers")
                        .HasColumnType("int");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Automobili");
                });

            modelBuilder.Entity("RentaCar.Models.Register", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("Eadresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Registar");
                });
#pragma warning restore 612, 618
        }
    }
}
