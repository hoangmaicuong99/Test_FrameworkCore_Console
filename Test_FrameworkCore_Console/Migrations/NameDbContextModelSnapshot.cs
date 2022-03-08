﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_FrameworkCore_Console.EF;

namespace Test_FrameworkCore_Console.Migrations
{
    [DbContext(typeof(NameDbContext))]
    partial class NameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.Product", b =>
                {
                    b.Property<long>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("productId");

                    b.HasIndex("userId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            productId = 1L,
                            productName = "Sản phẩm 1",
                            userId = 1L
                        },
                        new
                        {
                            productId = 2L,
                            productName = "Sản phẩm 2",
                            userId = 1L
                        });
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.Role", b =>
                {
                    b.Property<long>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            roleId = 1L,
                            description = "Mô tả vai trò 1",
                            roleName = "Vai trò 1"
                        },
                        new
                        {
                            roleId = 2L,
                            description = "Mô tả vai trò 2",
                            roleName = "Vai trò 2"
                        });
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.User", b =>
                {
                    b.Property<long>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            userId = 1L,
                            email = "hoangmaicuong99@gmail.com",
                            firstName = "Cuong",
                            lastName = "Hoang",
                            pass = "123"
                        });
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.UserDetail", b =>
                {
                    b.Property<long>("userDetailId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("createDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updateDay")
                        .HasColumnType("datetime2");

                    b.HasKey("userDetailId");

                    b.ToTable("UserDetail");

                    b.HasData(
                        new
                        {
                            userDetailId = 1L,
                            createDay = new DateTime(2022, 5, 8, 14, 40, 52, 531, DateTimeKind.Unspecified),
                            updateDay = new DateTime(2022, 5, 8, 14, 40, 52, 531, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.UserRole", b =>
                {
                    b.Property<long>("roleId")
                        .HasColumnType("bigint");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("roleId", "userId");

                    b.HasIndex("userId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            roleId = 1L,
                            userId = 1L
                        });
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.Product", b =>
                {
                    b.HasOne("Test_FrameworkCore_Console.Entities.User", "user")
                        .WithMany("products")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("user");
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.UserDetail", b =>
                {
                    b.HasOne("Test_FrameworkCore_Console.Entities.User", "user")
                        .WithOne("userDetail")
                        .HasForeignKey("Test_FrameworkCore_Console.Entities.UserDetail", "userDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.UserRole", b =>
                {
                    b.HasOne("Test_FrameworkCore_Console.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_FrameworkCore_Console.Entities.User", "user")
                        .WithMany("userRoles")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Test_FrameworkCore_Console.Entities.User", b =>
                {
                    b.Navigation("products");

                    b.Navigation("userDetail");

                    b.Navigation("userRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
