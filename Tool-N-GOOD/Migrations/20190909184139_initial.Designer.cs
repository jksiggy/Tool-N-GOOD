﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tool_N_GOOD.Data;

namespace Tool_N_GOOD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190909184139_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Occupation")
                        .IsRequired();

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2da557b-bdd3-4f26-8d48-e84ab4a08377",
                            Email = "warren@homedepot.com",
                            EmailConfirmed = true,
                            FirstName = "warren",
                            LastName = "delenger",
                            LockoutEnabled = false,
                            NormalizedEmail = "WARREN@HOMEDEPOT.COM",
                            NormalizedUserName = "WARREN@HOMEDEPOT.COM",
                            Occupation = "Mechanic 5",
                            PasswordHash = "AQAAAAEAACcQAAAAEAgb8dfCadUnOnP8NiYMmhdEDxzb4LbrOMNgjec1VmkBckcLxzYJiw+rXPvfvXZ3WQ==",
                            Phone = "615 473 434",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "warren@homedepot.com"
                        });
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.BrandType", b =>
                {
                    b.Property<int>("BrandTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("BrandTypeId");

                    b.ToTable("BrandTypes");

                    b.HasData(
                        new
                        {
                            BrandTypeId = 1,
                            Name = "DeWalt"
                        },
                        new
                        {
                            BrandTypeId = 2,
                            Name = "STANLEY"
                        },
                        new
                        {
                            BrandTypeId = 3,
                            Name = "STIHL"
                        },
                        new
                        {
                            BrandTypeId = 4,
                            Name = "Milwaukee"
                        },
                        new
                        {
                            BrandTypeId = 5,
                            Name = "RIGID"
                        });
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.MeasurementType", b =>
                {
                    b.Property<int>("MeasurementTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("MeasurementTypeId");

                    b.ToTable("MeasurementTypes");

                    b.HasData(
                        new
                        {
                            MeasurementTypeId = 1,
                            Type = "Standard"
                        },
                        new
                        {
                            MeasurementTypeId = 2,
                            Type = "Metrix"
                        });
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.Tool", b =>
                {
                    b.Property<int>("ToolId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandTypeId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Measurement")
                        .IsRequired();

                    b.Property<int?>("MeasurementTypeId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("ToolTypeId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("ToolId");

                    b.HasIndex("BrandTypeId");

                    b.HasIndex("MeasurementTypeId");

                    b.HasIndex("ToolTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Tools");

                    b.HasData(
                        new
                        {
                            ToolId = 1,
                            BrandTypeId = 3,
                            Description = "Red Handle",
                            Measurement = "14 inches",
                            MeasurementTypeId = 1,
                            Name = "Screw Driver",
                            ToolTypeId = 2,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ToolId = 2,
                            BrandTypeId = 1,
                            Description = "Sledge sides",
                            Measurement = "1/2 lbs",
                            MeasurementTypeId = 2,
                            Name = "Hammer",
                            ToolTypeId = 2,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ToolId = 3,
                            BrandTypeId = 2,
                            Description = "Silver Tip",
                            Measurement = "4 inches ",
                            MeasurementTypeId = 1,
                            Name = "Pipe Wrench",
                            ToolTypeId = 2,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            ToolId = 4,
                            BrandTypeId = 5,
                            Description = "Rubber handle",
                            Measurement = "3/4",
                            MeasurementTypeId = 2,
                            Name = "Pliers",
                            ToolTypeId = 1,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.ToolType", b =>
                {
                    b.Property<int>("ToolTypeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ToolTypeId");

                    b.ToTable("ToolTypes");

                    b.HasData(
                        new
                        {
                            ToolTypeId = 1,
                            Name = "Mechanic"
                        },
                        new
                        {
                            ToolTypeId = 2,
                            Name = "Farming"
                        },
                        new
                        {
                            ToolTypeId = 3,
                            Name = "Building Utility"
                        },
                        new
                        {
                            ToolTypeId = 4,
                            Name = "Appliances repair"
                        });
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.UsageHistory", b =>
                {
                    b.Property<int>("UsageHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CheckoutTime")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime?>("ExpectedReturn");

                    b.Property<bool>("Inspection");

                    b.Property<DateTime>("PromiseReturn");

                    b.Property<bool>("Serviceable");

                    b.Property<string>("TaskFor")
                        .IsRequired();

                    b.Property<int>("ToolId");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("UsageHistoryId");

                    b.HasIndex("ToolId");

                    b.HasIndex("UserId");

                    b.ToTable("UsageHistoryies");

                    b.HasData(
                        new
                        {
                            UsageHistoryId = 1,
                            ExpectedReturn = new DateTime(2019, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Inspection = true,
                            PromiseReturn = new DateTime(2019, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Serviceable = true,
                            TaskFor = "Fix the Gate",
                            ToolId = 4,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Tool_N_GOOD.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Tool_N_GOOD.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tool_N_GOOD.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Tool_N_GOOD.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.Tool", b =>
                {
                    b.HasOne("Tool_N_GOOD.Models.BrandType", "BrandType")
                        .WithMany("Tools")
                        .HasForeignKey("BrandTypeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Tool_N_GOOD.Models.MeasurementType", "MeasurementType")
                        .WithMany("Tools")
                        .HasForeignKey("MeasurementTypeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Tool_N_GOOD.Models.ToolType", "ToolType")
                        .WithMany("Tools")
                        .HasForeignKey("ToolTypeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Tool_N_GOOD.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tool_N_GOOD.Models.UsageHistory", b =>
                {
                    b.HasOne("Tool_N_GOOD.Models.Tool", "Tool")
                        .WithMany("UsageHistories")
                        .HasForeignKey("ToolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tool_N_GOOD.Models.ApplicationUser", "User")
                        .WithMany("UsageHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
