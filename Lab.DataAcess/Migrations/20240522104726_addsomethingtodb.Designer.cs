﻿// <auto-generated />
using System;
using Lab.DataAcess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab.DataAcess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240522104726_addsomethingtodb")]
    partial class addsomethingtodb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CDist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLandMark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CMobile")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("CPin")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("CPos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("CuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ClientId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CDist = "Baragachha",
                            CLandMark = "566",
                            CMobile = 1,
                            CPin = 564,
                            CPos = "Amba",
                            CuName = "Chiku"
                        },
                        new
                        {
                            Id = 2,
                            CDist = "Baragdsdachha",
                            CLandMark = "566",
                            CMobile = 12,
                            CPin = 42,
                            CPos = "Amdba",
                            CuName = "Chdiku"
                        },
                        new
                        {
                            Id = 3,
                            CDist = "Baragaachha",
                            CLandMark = "56236",
                            CMobile = 132,
                            CPin = 45,
                            CPos = "Adxcmba",
                            CuName = "Chdfiku"
                        });
                });

            modelBuilder.Entity("Lab.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Dist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandMark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Mobile")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("OfficerId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Pin")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Pos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Total")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("OfficerId");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CName = "Fortune of Time",
                            Count = 0,
                            Dist = "SWD9999001",
                            ImageUrl = "",
                            LandMark = "Near bara gachha",
                            Mobile = 123456789,
                            OfficerId = 1,
                            Pin = 90,
                            Pos = "Pankapal",
                            Total = 1399.0
                        },
                        new
                        {
                            Id = 2,
                            CName = "Fortune of Time",
                            Count = 0,
                            Dist = "SWD9999001",
                            ImageUrl = "",
                            LandMark = "Near bara gachha",
                            Mobile = 123456789,
                            OfficerId = 2,
                            Pin = 90,
                            Pos = "Pankapal",
                            Total = 1399.0
                        },
                        new
                        {
                            Id = 3,
                            CName = "Fortune of Time",
                            Count = 0,
                            Dist = "SWD9999001",
                            ImageUrl = "",
                            LandMark = "Near bara gachha",
                            Mobile = 123456789,
                            OfficerId = 1,
                            Pin = 90,
                            Pos = "Pankapal",
                            Total = 1399.0
                        },
                        new
                        {
                            Id = 4,
                            CName = "Fortune of Time",
                            Count = 0,
                            Dist = "SWD9999001",
                            ImageUrl = "",
                            LandMark = "Near bara gachha",
                            Mobile = 123456789,
                            OfficerId = 2,
                            Pin = 90,
                            Pos = "Pankapal",
                            Total = 1399.0
                        },
                        new
                        {
                            Id = 5,
                            CName = "Fortune of Time",
                            Count = 0,
                            Dist = "SWD9999001",
                            ImageUrl = "",
                            LandMark = "Near bara gachha",
                            Mobile = 123456789,
                            OfficerId = 1,
                            Pin = 90,
                            Pos = "Pankapal",
                            Total = 1399.0
                        },
                        new
                        {
                            Id = 6,
                            CName = "Fortune of Time",
                            Count = 0,
                            Dist = "SWD9999001",
                            ImageUrl = "",
                            LandMark = "Near bara gachha",
                            Mobile = 123456789,
                            OfficerId = 2,
                            Pin = 90,
                            Pos = "Pankapal",
                            Total = 1399.0
                        });
                });

            modelBuilder.Entity("Lab.Models.Officer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Officers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cost = 1,
                            Name = "Male"
                        },
                        new
                        {
                            Id = 2,
                            Cost = 2,
                            Name = "FeMale"
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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Lab.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dist")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OfficerId")
                        .HasColumnType("int");

                    b.Property<int?>("Pincode")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Pnumb")
                        .HasColumnType("int");

                    b.HasIndex("OfficerId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Lab.Models.Appointment", b =>
                {
                    b.HasOne("Lab.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Lab.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("ApplicationUser");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Lab.Models.Client", b =>
                {
                    b.HasOne("Lab.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("Lab.Models.Officer", "Officer")
                        .WithMany()
                        .HasForeignKey("OfficerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Officer");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lab.Models.ApplicationUser", b =>
                {
                    b.HasOne("Lab.Models.Officer", "Officer")
                        .WithMany()
                        .HasForeignKey("OfficerId");

                    b.Navigation("Officer");
                });
#pragma warning restore 612, 618
        }
    }
}
