﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VKTest.Data;

#nullable disable

namespace VKTest.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230505034207_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VKTest.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserGroupID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserStateID")
                        .HasColumnType("uuid");

                    b.HasKey("ID");

                    b.HasIndex("UserGroupID");

                    b.HasIndex("UserStateID");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("VKTest.Models.UserGroup", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("VKTest.Models.UserState", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("UserState", (string)null);
                });

            modelBuilder.Entity("VKTest.Models.User", b =>
                {
                    b.HasOne("VKTest.Models.UserGroup", "UserGroup")
                        .WithMany("Users")
                        .HasForeignKey("UserGroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VKTest.Models.UserState", "UserState")
                        .WithMany("Users")
                        .HasForeignKey("UserStateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserGroup");

                    b.Navigation("UserState");
                });

            modelBuilder.Entity("VKTest.Models.UserGroup", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("VKTest.Models.UserState", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
