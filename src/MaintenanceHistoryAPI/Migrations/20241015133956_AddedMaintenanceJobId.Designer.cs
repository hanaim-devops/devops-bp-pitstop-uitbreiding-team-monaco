﻿// <auto-generated />
using System;
using MaintenanceHistoryAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MaintenanceHistoryAPI.Migrations
{
    [DbContext(typeof(MaintenanceHistoryContext))]
    [Migration("20241015133956_AddedMaintenanceJobId")]
    partial class AddedMaintenanceJobId
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MaintenanceHistoryAPI.Model.MaintenanceHistory", b =>
                {
                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MaintenanceDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MaintenanceJobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MaintenanceType")
                        .HasColumnType("int");

                    b.HasKey("LicenseNumber");

                    b.ToTable("MaintenanceHistory", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
