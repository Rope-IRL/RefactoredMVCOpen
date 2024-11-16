﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefactoredMVC.DataAccess;

#nullable disable

namespace RefactoredMVC.DataAccess.MsSql.Migrations
{
    [DbContext(typeof(RentDbContext))]
    [Migration("20241116105635_NamingChanging")]
    partial class NamingChanging
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.FlatContractEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("MONEY");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("FlatId")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("LesseeId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("FlatId");

                    b.HasIndex("LandlordId");

                    b.HasIndex("LesseeId");

                    b.ToTable("FlatContracts");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.FlatEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("AverageMark")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("CostPerDay")
                        .HasPrecision(18, 2)
                        .HasColumnType("MONEY");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsBathroomAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWiFiAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("LlId")
                        .HasColumnType("int");

                    b.Property<short>("NumberOfFloors")
                        .HasColumnType("smallint");

                    b.Property<short>("NumberOfRooms")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("LlId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HotelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AverageMark")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("LlId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LlId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HouseContractEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("MONEY");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("HouseId")
                        .HasColumnType("int");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("LesseeId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("LandlordId");

                    b.HasIndex("LesseeId");

                    b.ToTable("HouseContracts");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HouseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("AverageMark")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("CostPerDay")
                        .HasPrecision(18, 2)
                        .HasColumnType("MONEY");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsBathroomAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWiFiAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("LlId")
                        .HasColumnType("int");

                    b.Property<short>("NumberOfFloors")
                        .HasColumnType("smallint");

                    b.Property<short>("NumberOfRooms")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("LlId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LandlordAdditionalInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AverageMark")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PassportId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId")
                        .IsUnique();

                    b.ToTable("LandlordAdditionalInfos");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LandlordEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Landlords");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LesseeAdditionalInfoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AverageMark")
                        .HasPrecision(2, 1)
                        .HasColumnType("decimal(2,1)");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("LesseeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PassportId")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.HasIndex("LesseeId")
                        .IsUnique();

                    b.ToTable("LesseeAdditionalInfos");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LesseeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Lessees");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.RoomContractEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("MONEY");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("LandlordId")
                        .HasColumnType("int");

                    b.Property<int>("LesseeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("LandlordId");

                    b.HasIndex("LesseeId");

                    b.HasIndex("RoomId");

                    b.ToTable("RoomContracts");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.RoomEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CostPerDay")
                        .HasPrecision(18, 2)
                        .HasColumnType("MONEY");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("HouId")
                        .HasColumnType("int");

                    b.Property<bool>("IsBathroomAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWiFiAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HouId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.FlatContractEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.FlatEntity", "Flat")
                        .WithMany("Contracts")
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RefactoredMVC.DataAccess.Entities.LandlordEntity", "Landlord")
                        .WithMany("FlatContracts")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RefactoredMVC.DataAccess.Entities.LesseeEntity", "Lessee")
                        .WithMany("FlatContracts")
                        .HasForeignKey("LesseeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Flat");

                    b.Navigation("Landlord");

                    b.Navigation("Lessee");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.FlatEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.LandlordEntity", "LandLord")
                        .WithMany("Flats")
                        .HasForeignKey("LlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LandLord");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HotelEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.LandlordEntity", "LandLord")
                        .WithMany("Hotels")
                        .HasForeignKey("LlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LandLord");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HouseContractEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.HouseEntity", "House")
                        .WithMany("Contracts")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RefactoredMVC.DataAccess.Entities.LandlordEntity", "Landlord")
                        .WithMany("HouseContracts")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RefactoredMVC.DataAccess.Entities.LesseeEntity", "Lessee")
                        .WithMany("HouseContracts")
                        .HasForeignKey("LesseeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("Landlord");

                    b.Navigation("Lessee");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HouseEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.LandlordEntity", "LandLord")
                        .WithMany("Houses")
                        .HasForeignKey("LlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LandLord");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LandlordAdditionalInfoEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.LandlordEntity", "Landlord")
                        .WithOne("AdditionalInfo")
                        .HasForeignKey("RefactoredMVC.DataAccess.Entities.LandlordAdditionalInfoEntity", "LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Landlord");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LesseeAdditionalInfoEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.LesseeEntity", "Lessee")
                        .WithOne("AdditionalInfo")
                        .HasForeignKey("RefactoredMVC.DataAccess.Entities.LesseeAdditionalInfoEntity", "LesseeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lessee");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.RoomContractEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.LandlordEntity", "Landlord")
                        .WithMany("RoomContracts")
                        .HasForeignKey("LandlordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefactoredMVC.DataAccess.Entities.LesseeEntity", "Lessee")
                        .WithMany("RoomContracts")
                        .HasForeignKey("LesseeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RefactoredMVC.DataAccess.Entities.RoomEntity", "Room")
                        .WithMany("Contracts")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Landlord");

                    b.Navigation("Lessee");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.RoomEntity", b =>
                {
                    b.HasOne("RefactoredMVC.DataAccess.Entities.HotelEntity", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HouId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.FlatEntity", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HotelEntity", b =>
                {
                    b.Navigation("HotelRooms");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.HouseEntity", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LandlordEntity", b =>
                {
                    b.Navigation("AdditionalInfo")
                        .IsRequired();

                    b.Navigation("FlatContracts");

                    b.Navigation("Flats");

                    b.Navigation("Hotels");

                    b.Navigation("HouseContracts");

                    b.Navigation("Houses");

                    b.Navigation("RoomContracts");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.LesseeEntity", b =>
                {
                    b.Navigation("AdditionalInfo")
                        .IsRequired();

                    b.Navigation("FlatContracts");

                    b.Navigation("HouseContracts");

                    b.Navigation("RoomContracts");
                });

            modelBuilder.Entity("RefactoredMVC.DataAccess.Entities.RoomEntity", b =>
                {
                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}
