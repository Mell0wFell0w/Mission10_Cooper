﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission10_API.Data;
using System.Reflection.Emit;

#nullable disable

namespace Mission10_API.Migrations
{
    [DbContext(typeof(BowlerContext))]
    [Migration("20240310001441_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Mission10_API.Data.BowlerList", b =>
            {
                b.Property<int>("BowlerID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("BowlerAddress")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("BowlerCity")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("BowlerFirstName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("BowlerLastName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("BowlerMiddleInit")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("BowlerPhoneNumber")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("BowlerState")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("BowlerZip")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("TeamID")
                    .HasColumnType("INTEGER");

                b.Property<int>("TeamNameTeamID")
                    .HasColumnType("INTEGER");

                b.HasKey("BowlerID");

                b.HasIndex("TeamNameTeamID");

                b.ToTable("Bowlers");
            });

            modelBuilder.Entity("Mission10_API.Data.Teams", b =>
            {
                b.Property<int>("TeamID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("TeamName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("TeamID");

                b.ToTable("Team");

                b.HasData(
                    new
                    {
                        TeamID = 1,
                        TeamName = "Marlins"
                    },
                    new
                    {
                        TeamID = 2,
                        TeamName = "Sharks"
                    },
                    new
                    {
                        TeamID = 3,
                        TeamName = "Terrapins"
                    },
                    new
                    {
                        TeamID = 4,
                        TeamName = "Barracudas"
                    },
                    new
                    {
                        TeamID = 5,
                        TeamName = "Dolphins"
                    },
                    new
                    {
                        TeamID = 6,
                        TeamName = "Orcas"
                    },
                    new
                    {
                        TeamID = 7,
                        TeamName = "Manatees"
                    },
                    new
                    {
                        TeamID = 8,
                        TeamName = "Swordfish"
                    },
                    new
                    {
                        TeamID = 9,
                        TeamName = "Huckleberrys"
                    },
                    new
                    {
                        TeamID = 10,
                        TeamName = "MintJuleps"
                    });
            });

            modelBuilder.Entity("Mission10_API.Data.BowlerList", b =>
            {
                b.HasOne("Mission10_API.Data.Teams", "TeamName")
                    .WithMany()
                    .HasForeignKey("TeamNameTeamID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("TeamName");
            });
#pragma warning restore 612, 618
        }
    }
}