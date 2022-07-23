﻿// <auto-generated />
using System;
using Asp.netCoreMvcCrud.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.netCoreMvcCrud.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20220723170302_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.netCoreMvcCrud.Models.Conge", b =>
                {
                    b.Property<int>("CongeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateDebut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateFin")
                        .HasColumnType("datetime2");

                    b.HasKey("CongeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Conges");
                });

            modelBuilder.Entity("Asp.netCoreMvcCrud.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EmpCode")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Position")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Salaire")
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Asp.netCoreMvcCrud.Models.Conge", b =>
                {
                    b.HasOne("Asp.netCoreMvcCrud.Models.Employee", "Employee")
                        .WithMany("conges")
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}
