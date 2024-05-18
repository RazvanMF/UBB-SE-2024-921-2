﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NamespaceGPT_ASP.NET_Repository.DatabaseContext;

#nullable disable

namespace NamespaceGPT_ASP.NET_Repository.Migrations
{
    [DbContext(typeof(ProjectDBContext))]
    [Migration("20240517180635_LegacyToCodeFirst_v3")]
    partial class LegacyToCodeFirst_v3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NamespaceGPT.Data.Models.AdRecommendation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.ToTable("AdRecommendation");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.BackInStockAlert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketplaceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarketplaceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("BackInStockAlerts");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.FavouriteProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("FavouriteProduct");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Listing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MarketplaceId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarketplaceId");

                    b.HasIndex("ProductId");

                    b.ToTable("Listing");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Marketplace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarketplaceName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("WebsiteURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marketplace");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.NewProductAlert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MarketplaceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarketplaceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("NewProductAlerts");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.PriceDropAlert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MarketplaceId")
                        .HasColumnType("int");

                    b.Property<decimal>("NewPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OldPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarketplaceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("PriceDropAlerts");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Attributes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListingId");

                    b.HasIndex("UserId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.UserActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserActivity");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.AdRecommendation", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Listing", "Listing")
                        .WithMany("AdRecommendations")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.BackInStockAlert", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Marketplace", "Marketplace")
                        .WithMany("BackInStockAlerts")
                        .HasForeignKey("MarketplaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.Product", "Product")
                        .WithMany("BackInStockAlerts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.User", "User")
                        .WithMany("BackInStockAlerts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marketplace");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.FavouriteProduct", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Product", "Product")
                        .WithMany("FavouriteProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.User", "User")
                        .WithMany("FavouriteProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Listing", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Marketplace", "Marketplace")
                        .WithMany("Listings")
                        .HasForeignKey("MarketplaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.Product", "Product")
                        .WithMany("Listings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Marketplace");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.NewProductAlert", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Marketplace", null)
                        .WithMany("NewProductAlerts")
                        .HasForeignKey("MarketplaceId");

                    b.HasOne("NamespaceGPT.Data.Models.Product", "Product")
                        .WithMany("NewProductAlerts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.User", "User")
                        .WithMany("NewProductAlerts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.PriceDropAlert", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Marketplace", null)
                        .WithMany("PriceDropAlerts")
                        .HasForeignKey("MarketplaceId");

                    b.HasOne("NamespaceGPT.Data.Models.Product", "Product")
                        .WithMany("PriceDropAlerts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.User", "User")
                        .WithMany("PriceDropAlerts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Review", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.User", "User")
                        .WithMany("Review")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Sale", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.Listing", "Listing")
                        .WithMany("Sales")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NamespaceGPT.Data.Models.User", "User")
                        .WithMany("Sales")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Listing");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.UserActivity", b =>
                {
                    b.HasOne("NamespaceGPT.Data.Models.User", "User")
                        .WithMany("UserActivities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Listing", b =>
                {
                    b.Navigation("AdRecommendations");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Marketplace", b =>
                {
                    b.Navigation("BackInStockAlerts");

                    b.Navigation("Listings");

                    b.Navigation("NewProductAlerts");

                    b.Navigation("PriceDropAlerts");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.Product", b =>
                {
                    b.Navigation("BackInStockAlerts");

                    b.Navigation("FavouriteProducts");

                    b.Navigation("Listings");

                    b.Navigation("NewProductAlerts");

                    b.Navigation("PriceDropAlerts");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("NamespaceGPT.Data.Models.User", b =>
                {
                    b.Navigation("BackInStockAlerts");

                    b.Navigation("FavouriteProducts");

                    b.Navigation("NewProductAlerts");

                    b.Navigation("PriceDropAlerts");

                    b.Navigation("Review");

                    b.Navigation("Sales");

                    b.Navigation("UserActivities");
                });
#pragma warning restore 612, 618
        }
    }
}
