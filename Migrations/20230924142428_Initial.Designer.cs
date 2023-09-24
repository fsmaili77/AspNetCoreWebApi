﻿// <auto-generated />
using System;
using CitiesManagerWebAPI.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitiesManagerWebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230924142428_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CitiesManagerWebAPI.Models.City", b =>
                {
                    b.Property<Guid>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = new Guid("04206c4e-b0a7-48f2-9159-27bddddc748c"),
                            CityName = "Paris"
                        },
                        new
                        {
                            CityID = new Guid("7eefebe3-5a43-4a89-818e-1c8ae50ec847"),
                            CityName = "London"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
