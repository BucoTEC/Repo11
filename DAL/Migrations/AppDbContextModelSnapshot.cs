﻿// <auto-generated />
using System;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AppUserRoleId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserRoleId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "02174cf0-9412-4cfe-afbf-59f706d72cf6",
                            AccessFailedCount = 0,
                            AppUserRoleId = 2,
                            ConcurrencyStamp = "35def285-64cc-482d-b3df-f8105ecd539b",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5916),
                            DeletedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5919),
                            Email = "adnan@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Adnan",
                            IsActive = true,
                            LastName = "Bucalovic",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADNAN@GMAIL.COM",
                            NormalizedUserName = "ADNAN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEH0DtHEg4OWTEVFupVbPYNFdKGUdVyPZNMK+StnhYSl/wLWuDttRp1CFnZq9NI338w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ff805230-9d41-4606-bec7-f05a61c25133",
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5918),
                            UserName = "adnan@gmail.com"
                        },
                        new
                        {
                            Id = "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                            AccessFailedCount = 0,
                            AppUserRoleId = 1,
                            ConcurrencyStamp = "b0ae7aab-203e-450f-aa43-41db1fb5d4ee",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 824, DateTimeKind.Local).AddTicks(9426),
                            DeletedAt = new DateTime(2022, 12, 4, 0, 26, 21, 824, DateTimeKind.Local).AddTicks(9429),
                            Email = "advan@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Advan",
                            IsActive = true,
                            LastName = "Bucalovic",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADVAN@GMAIL.COM",
                            NormalizedUserName = "ADVAN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBn/oWF65/yxr2si6JEhar8IS5Z7OxAR4nUGUlizQLKN764sZ+YVIsM6BwMaw4KNGg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eb0c11b5-2e06-4a5e-a41b-5bc1ba7f59ae",
                            TwoFactorEnabled = false,
                            UpdatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 824, DateTimeKind.Local).AddTicks(9428),
                            UserName = "advan@gmail.com"
                        });
                });

            modelBuilder.Entity("DAL.Entities.AppUserRole", b =>
                {
                    b.Property<int>("AppUserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppUserRoleId"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("AppUserRoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            AppUserRoleId = 1,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5726),
                            Name = "Customer"
                        },
                        new
                        {
                            AppUserRoleId = 2,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5772),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("DAL.Entities.CartItem", b =>
                {
                    b.Property<int>("CartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemId"), 1L, 1);

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CartItemId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");

                    b.HasData(
                        new
                        {
                            CartItemId = 1,
                            AppUserId = "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1050),
                            IsSelected = true,
                            ProductId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            CartItemId = 2,
                            AppUserId = "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1053),
                            IsSelected = false,
                            ProductId = 2,
                            Quantity = 4
                        },
                        new
                        {
                            CartItemId = 3,
                            AppUserId = "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1054),
                            IsSelected = true,
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            CartItemId = 4,
                            AppUserId = "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1055),
                            IsSelected = false,
                            ProductId = 4,
                            Quantity = 2
                        });
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5882),
                            Name = "Single-Vision",
                            ParentId = 0
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5884),
                            Name = "Bifocals",
                            ParentId = 0
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5886),
                            Name = "Trifocals",
                            ParentId = 0
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5887),
                            Name = "Progressives",
                            ParentId = 0
                        });
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            Address = "Kemala Kapetanovica 13.",
                            AppUserId = "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                            City = "Sarajevo",
                            Country = "BiH",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1089),
                            PhoneNumber = "062656323",
                            ReceiverName = "Advan Bucalovic"
                        },
                        new
                        {
                            OrderId = 2,
                            Address = "Kemala Kapetanovica 13.",
                            AppUserId = "341743f0-asd2-42de-afbf-59kmkkmk72cf6",
                            City = "Sarajevo",
                            Country = "BiH",
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1092),
                            PhoneNumber = "062656323",
                            ReceiverName = "Advan Bucalovic"
                        });
                });

            modelBuilder.Entity("DAL.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("ShippingPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1072),
                            Name = "Glasses one",
                            OrderId = 1,
                            Price = 123.99m,
                            ProductId = 1,
                            Quantity = 1,
                            ShippingPrice = 9.99m
                        },
                        new
                        {
                            OrderItemId = 2,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1075),
                            Name = "Glasses two",
                            OrderId = 1,
                            Price = 333.99m,
                            ProductId = 2,
                            Quantity = 3,
                            ShippingPrice = 9.99m
                        },
                        new
                        {
                            OrderItemId = 3,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1077),
                            Name = "Glasses three",
                            OrderId = 2,
                            Price = 423.99m,
                            ProductId = 3,
                            Quantity = 1,
                            ShippingPrice = 9.99m
                        },
                        new
                        {
                            OrderItemId = 4,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 826, DateTimeKind.Local).AddTicks(1078),
                            Name = "Glasses four",
                            OrderId = 2,
                            Price = 523.99m,
                            ProductId = 4,
                            Quantity = 2,
                            ShippingPrice = 9.99m
                        });
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("AvailableAmount")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("ShippingPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AvailableAmount = 9,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5899),
                            Description = "Glasses one description",
                            Name = "Glasses one",
                            Price = 123.99m,
                            ShippingPrice = 9.99m
                        },
                        new
                        {
                            ProductId = 2,
                            AvailableAmount = 7,
                            CategoryId = 2,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5906),
                            Description = "Glasses two description",
                            Name = "Glasses two",
                            Price = 333.99m,
                            ShippingPrice = 9.99m
                        },
                        new
                        {
                            ProductId = 3,
                            AvailableAmount = 4,
                            CategoryId = 3,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5908),
                            Description = "Glasses three description",
                            Name = "Glasses three",
                            Price = 423.99m,
                            ShippingPrice = 9.99m
                        },
                        new
                        {
                            ProductId = 4,
                            AvailableAmount = 12,
                            CategoryId = 4,
                            CreatedAt = new DateTime(2022, 12, 4, 0, 26, 21, 823, DateTimeKind.Local).AddTicks(5909),
                            Description = "Glasses fore description",
                            Name = "Glasses fore",
                            Price = 523.99m,
                            ShippingPrice = 9.99m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.AppUser", b =>
                {
                    b.HasOne("DAL.Entities.AppUserRole", "AppUserRole")
                        .WithMany()
                        .HasForeignKey("AppUserRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUserRole");
                });

            modelBuilder.Entity("DAL.Entities.CartItem", b =>
                {
                    b.HasOne("DAL.Entities.AppUser", "AppUser")
                        .WithMany("CartItems")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.HasOne("DAL.Entities.AppUser", "AppUser")
                        .WithMany("Orders")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("DAL.Entities.OrderItem", b =>
                {
                    b.HasOne("DAL.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Entities.Product", b =>
                {
                    b.HasOne("DAL.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.AppUser", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("DAL.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
