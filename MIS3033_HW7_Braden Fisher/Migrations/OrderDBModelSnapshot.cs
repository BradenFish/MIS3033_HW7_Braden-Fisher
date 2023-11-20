﻿// <auto-generated />
using MIS3033_HW7_Braden_Fisher.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MIS3033_HW7_Braden_Fisher.Migrations
{
    [DbContext(typeof(OrderDB))]
    partial class OrderDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MIS3033_HW7_Braden_Fisher.Models.Order", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<int>("level")
                        .HasColumnType("integer");

                    b.Property<int>("nCogs")
                        .HasColumnType("integer");

                    b.Property<int>("nGears")
                        .HasColumnType("integer");

                    b.Property<double>("subtotal")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
