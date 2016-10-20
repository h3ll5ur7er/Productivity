using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Productivity.Persistence;

namespace Productivity.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20161020131205_DataModelAddded")]
    partial class DataModelAddded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("Productivity.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Personen");
                });

            modelBuilder.Entity("Productivity.Models.Neubau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<double>("FaktorMontageArt");

                    b.Property<double>("FaktorStockwerk");

                    b.Property<double>("FaktorSystem");

                    b.Property<double>("FaktorZugang");

                    b.Property<int>("KW");

                    b.Property<double>("Produktivitaet");

                    b.Property<double>("Wirtschaftlichkeit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Neubau");
                });

            modelBuilder.Entity("Productivity.Models.Umbau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeId");

                    b.Property<double>("FaktorMontageArt");

                    b.Property<double>("FaktorStockwerk");

                    b.Property<double>("FaktorSystem");

                    b.Property<double>("FaktorZugang");

                    b.Property<int>("KW");

                    b.Property<double>("Produktivitaet");

                    b.Property<double>("Wirtschaftlichkeit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Umbau");
                });

            modelBuilder.Entity("Productivity.Models.Neubau", b =>
                {
                    b.HasOne("Productivity.Models.Employee", "Employee")
                        .WithMany("Neubau")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Productivity.Models.Umbau", b =>
                {
                    b.HasOne("Productivity.Models.Employee", "Employee")
                        .WithMany("Umbau")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
