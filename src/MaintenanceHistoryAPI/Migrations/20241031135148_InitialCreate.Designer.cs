﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pitstop.MaintenanceHistoryAPI.DataAccess;

#nullable disable

namespace Pitstop.MaintenanceHistoryAPI.Migrations
{
    [DbContext(typeof(MaintenanceHistoryContext))]
    [Migration("20241031135148_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pitstop.MaintenanceHistoryAPI.Model.MaintenanceHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MaintenanceDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MaintenanceJobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaintenanceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MaintenanceHistory", (string)null);
                });

            modelBuilder.Entity("Pitstop.MaintenanceHistoryAPI.Model.RepairPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WarrantyPeriod")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RepairParts", (string)null);
                });

            modelBuilder.Entity("Pitstop.MaintenanceHistoryAPI.Model.UsedPart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaintenanceHistoryId")
                        .HasColumnType("int");

                    b.Property<int>("RepairPartId")
                        .HasColumnType("int");

                    b.Property<int>("UsedQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MaintenanceHistoryId");

                    b.HasIndex("RepairPartId");

                    b.ToTable("UsedParts", (string)null);
                });

            modelBuilder.Entity("Pitstop.MaintenanceHistoryAPI.Model.UsedPart", b =>
                {
                    b.HasOne("Pitstop.MaintenanceHistoryAPI.Model.MaintenanceHistory", "MaintenanceHistory")
                        .WithMany("UsedParts")
                        .HasForeignKey("MaintenanceHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pitstop.MaintenanceHistoryAPI.Model.RepairPart", "RepairPart")
                        .WithMany()
                        .HasForeignKey("RepairPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MaintenanceHistory");

                    b.Navigation("RepairPart");
                });

            modelBuilder.Entity("Pitstop.MaintenanceHistoryAPI.Model.MaintenanceHistory", b =>
                {
                    b.Navigation("UsedParts");
                });
#pragma warning restore 612, 618
        }
    }
}
