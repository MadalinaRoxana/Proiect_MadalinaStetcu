﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_MP_Madalina.Models;

namespace Proiect_MP_Madalina.Migrations
{
    [DbContext(typeof(Proiect_MP_MadalinaContext))]
    [Migration("20230110222238_Migrare1-6")]
    partial class Migrare16
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect_MP_Madalina.Models.Autor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor_Nume")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("Proiect_MP_Madalina.Models.JoinScenetaWTeatru", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ScenetaID");

                    b.Property<int>("TeatruID");

                    b.HasKey("ID");

                    b.HasIndex("ScenetaID");

                    b.HasIndex("TeatruID");

                    b.ToTable("JoinScenetaWTeatru");
                });

            modelBuilder.Entity("Proiect_MP_Madalina.Models.Sceneta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutorID");

                    b.Property<string>("Sceneta_categorie")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<DateTime>("Sceneta_data");

                    b.Property<string>("Sceneta_denumire")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("Sceneta_pret");

                    b.Property<int>("Sceneta_varsta");

                    b.Property<int>("TeatruID");

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.HasIndex("TeatruID");

                    b.ToTable("Sceneta");
                });

            modelBuilder.Entity("Proiect_MP_Madalina.Models.Teatru", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Teatru_Denumire")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Teatru");
                });

            modelBuilder.Entity("Proiect_MP_Madalina.Models.JoinScenetaWTeatru", b =>
                {
                    b.HasOne("Proiect_MP_Madalina.Models.Sceneta", "Sceneta")
                        .WithMany("JoinScenetaWTeatru")
                        .HasForeignKey("ScenetaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proiect_MP_Madalina.Models.Teatru", "Teatru")
                        .WithMany("JoinScenetaWTeatru")
                        .HasForeignKey("TeatruID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Proiect_MP_Madalina.Models.Sceneta", b =>
                {
                    b.HasOne("Proiect_MP_Madalina.Models.Autor", "Autor")
                        .WithMany("Sceneta")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Proiect_MP_Madalina.Models.Teatru", "Teatru")
                        .WithMany()
                        .HasForeignKey("TeatruID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
