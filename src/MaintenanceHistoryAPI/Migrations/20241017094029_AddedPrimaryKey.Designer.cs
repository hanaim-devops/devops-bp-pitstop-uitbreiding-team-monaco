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
    [Migration("20241017094029_AddedPrimaryKey")]
    partial class AddedPrimaryKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MaintenanceHistoryAPI.Model.MaintenanceHistory", b =>
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
#pragma warning restore 612, 618
        }
    }
}