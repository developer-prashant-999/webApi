﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokemonReviewApp.Data;

#nullable disable

namespace PokemonReviewApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221003080901_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PokemonReviewApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Gym")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("countryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("countryId");

                    b.ToTable("owners");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.PokemonCatagory", b =>
                {
                    b.Property<int>("CatagoryId")
                        .HasColumnType("int");

                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.HasKey("CatagoryId", "PokemonId");

                    b.HasIndex("PokemonId");

                    b.ToTable("pokemonCatagories");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.PokemonOwner", b =>
                {
                    b.Property<int>("PokemonId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("PokemonId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("pokemonOwners");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pokemonId")
                        .HasColumnType("int");

                    b.Property<int>("reviewerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("pokemonId");

                    b.HasIndex("reviewerId");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("reviewers");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Owner", b =>
                {
                    b.HasOne("PokemonReviewApp.Models.Country", "country")
                        .WithMany("Owners")
                        .HasForeignKey("countryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.PokemonCatagory", b =>
                {
                    b.HasOne("PokemonReviewApp.Models.Category", "category")
                        .WithMany("PokemonCatagories")
                        .HasForeignKey("CatagoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonReviewApp.Models.Pokemon", "Pokemon")
                        .WithMany("PokemonCatagories")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pokemon");

                    b.Navigation("category");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.PokemonOwner", b =>
                {
                    b.HasOne("PokemonReviewApp.Models.Owner", "Owner")
                        .WithMany("pokemonOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonReviewApp.Models.Pokemon", "Pokemon")
                        .WithMany("pokemonOwners")
                        .HasForeignKey("PokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Review", b =>
                {
                    b.HasOne("PokemonReviewApp.Models.Pokemon", "pokemon")
                        .WithMany("Review")
                        .HasForeignKey("pokemonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonReviewApp.Models.Reviewer", "reviewer")
                        .WithMany("Review")
                        .HasForeignKey("reviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pokemon");

                    b.Navigation("reviewer");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Category", b =>
                {
                    b.Navigation("PokemonCatagories");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Country", b =>
                {
                    b.Navigation("Owners");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Owner", b =>
                {
                    b.Navigation("pokemonOwners");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Pokemon", b =>
                {
                    b.Navigation("PokemonCatagories");

                    b.Navigation("Review");

                    b.Navigation("pokemonOwners");
                });

            modelBuilder.Entity("PokemonReviewApp.Models.Reviewer", b =>
                {
                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}