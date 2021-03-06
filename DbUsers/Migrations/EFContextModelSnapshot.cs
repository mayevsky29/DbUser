﻿// <auto-generated />
using System;
using DbUsers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DbUsers.Migrations
{
    [DbContext(typeof(EFContext))]
    partial class EFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DbUsers.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Image")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<string>("UrlSlug")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("tblCategories");
                });

            modelBuilder.Entity("DbUsers.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("tblRoles");
                });

            modelBuilder.Entity("DbUsers.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Image")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("tblUsers");
                });

            modelBuilder.Entity("DbUsers.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("tblUserRoles");
                });

            modelBuilder.Entity("DbUsers.Entities.Category", b =>
                {
                    b.HasOne("DbUsers.Entities.Category", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("DbUsers.Entities.UserRole", b =>
                {
                    b.HasOne("DbUsers.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbUsers.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
