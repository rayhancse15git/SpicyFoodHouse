﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SpicyFoodHouse.Data;
using System;

namespace SpicyFoodHouse.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
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
                        .ValueGeneratedOnAdd();

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
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

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

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CustomerName");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<byte[]>("NidOrBith");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<int>("Phone");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<byte[]>("ProfileImage");

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
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.AvailableInStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AvailableFood");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("ManagerSignature");

                    b.HasKey("Id");

                    b.ToTable("AvailableInStock");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasMaxLength(1500);

                    b.Property<DateTime>("CommentTime");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.DeliveryCharge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Charge");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<DateTime>("EntryDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("LocationRange")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ManagerSignature");

                    b.HasKey("Id");

                    b.ToTable("DeliveryCharge");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvailableInStock")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<float>("Discount");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<byte[]>("Image")
                        .IsRequired();

                    b.Property<bool>("IsDiscounted");

                    b.Property<bool>("IsPopular");

                    b.Property<bool>("IsTranding");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("ManagerSignature");

                    b.Property<float>("Price");

                    b.Property<int>("TypeId");

                    b.HasKey("FoodId");

                    b.HasIndex("TypeId");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.FoodOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerEmail");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("FoodName2")
                        .HasMaxLength(200);

                    b.Property<string>("FoodName3")
                        .HasMaxLength(200);

                    b.Property<bool>("IsAccepted");

                    b.Property<bool>("IsPaid");

                    b.Property<bool>("IsRejected");

                    b.Property<bool>("IsSeen");

                    b.Property<int>("LastFiveDigit");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("NumberOfFood");

                    b.Property<int>("NumberOfFood2");

                    b.Property<int>("NumberOfFood3");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("PaymentMethodId");

                    b.Property<float>("Price");

                    b.Property<float>("Price2");

                    b.Property<float>("Price3");

                    b.Property<int>("QuarterId");

                    b.Property<int>("QuarterId2");

                    b.Property<int>("QuarterId3");

                    b.Property<float>("SubTotalPrice");

                    b.Property<float>("TotalPrice");

                    b.Property<float>("TotalPrice2");

                    b.Property<float>("TotalPrice3");

                    b.Property<int>("TypeId");

                    b.Property<int>("TypeId2");

                    b.Property<int>("TypeId3");

                    b.HasKey("OrderId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("QuarterId");

                    b.HasIndex("TypeId");

                    b.ToTable("FoodOrder");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.FoodQuarter", b =>
                {
                    b.Property<int>("QuarterId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("ManagerSignature");

                    b.Property<string>("QuarterName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("QuarterId");

                    b.ToTable("FoodQuarter");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.FoodType", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("ManagerSignature");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("TypeId");

                    b.ToTable("FoodType");
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EntryDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("ManagerSignature");

                    b.Property<string>("PaymentMethodName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethod");
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
                    b.HasOne("SpicyFoodHouse.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SpicyFoodHouse.Models.ApplicationUser")
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

                    b.HasOne("SpicyFoodHouse.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SpicyFoodHouse.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.Food", b =>
                {
                    b.HasOne("SpicyFoodHouse.Models.FoodType", "FoodType")
                        .WithMany("Food")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SpicyFoodHouse.Models.FoodOrder", b =>
                {
                    b.HasOne("SpicyFoodHouse.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("FoodOrder")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpicyFoodHouse.Models.FoodQuarter", "FoodQuarter")
                        .WithMany("FoodOrder")
                        .HasForeignKey("QuarterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SpicyFoodHouse.Models.FoodType", "FoodType")
                        .WithMany("FoodOrder")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
