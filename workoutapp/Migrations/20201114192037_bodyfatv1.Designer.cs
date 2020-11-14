﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using workoutapp.Data;

namespace workoutapp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201114192037_bodyfatv1")]
    partial class bodyfatv1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("workoutapp.Models.BMICalculator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Result")
                        .HasColumnType("REAL");

                    b.Property<bool>("Save")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("BMIResults");
                });

            modelBuilder.Entity("workoutapp.Models.BodyFatCalculator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<double>("BodyFatPercentage")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("FatMass")
                        .HasColumnType("REAL");

                    b.Property<bool>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Hip")
                        .HasColumnType("REAL");

                    b.Property<double>("LeanMass")
                        .HasColumnType("REAL");

                    b.Property<double>("Neck")
                        .HasColumnType("REAL");

                    b.Property<bool>("Save")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Waist")
                        .HasColumnType("REAL");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("BodyFatCalculator");
                });

            modelBuilder.Entity("workoutapp.Models.BodyMeasure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("BicepsRight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bicepsleft")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalfLeft")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalfRight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Chest")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("Hips")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Midsection")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ThighLeft")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ThighRight")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Waist")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("BodyMeasure");
                });

            modelBuilder.Entity("workoutapp.Models.Exercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
