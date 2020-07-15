﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserAuthenticationAPI.DataAccess.RepositoryBase;

namespace UserAuthenticationAPI.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20200715100227_CreateUserRolesTable")]
    partial class CreateUserRolesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UserAuthenticationAPI.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)")
                        .HasMaxLength(20);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)")
                        .HasMaxLength(16);

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserAuthenticationAPI.Models.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("RolePriority")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasColumnType("varchar(MAX)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
