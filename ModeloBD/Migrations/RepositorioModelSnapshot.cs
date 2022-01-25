﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloBD;

namespace ModeloBD.Migrations
{
    [DbContext(typeof(Repositorio))]
    partial class RepositorioModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Last_update")
                        .HasColumnType("datetime2");

                    b.HasKey("ActorId");

                    b.ToTable("actors");
                });

            modelBuilder.Entity("Modelo.Entidades.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Last_update")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("Modelo.Entidades.Film_actor", b =>
                {
                    b.Property<int>("Film_actorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("Film_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Last_Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Film_actorId");

                    b.HasIndex("ActorId");

                    b.ToTable("film_actors");
                });

            modelBuilder.Entity("Modelo.Entidades.Film_actor", b =>
                {
                    b.HasOne("Modelo.Entidades.Actor", "Actor")
                        .WithMany("Film_actors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("Modelo.Entidades.Actor", b =>
                {
                    b.Navigation("Film_actors");
                });
#pragma warning restore 612, 618
        }
    }
}
