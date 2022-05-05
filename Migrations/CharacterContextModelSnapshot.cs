﻿// <auto-generated />
using System;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADV_Bus_Pro_FinalProject_1.Migrations
{
    [DbContext(typeof(CharacterContext))]
    partial class CharacterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("FinalProject.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Charisma")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Dexterity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int>("Intelligence")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.Property<int>("Strength")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("WeaponId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CharacterId");

                    b.HasIndex("WeaponId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("FinalProject.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CharacterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Damage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Reach")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WeaponName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("WeaponId");

                    b.ToTable("Weapon");
                });

            modelBuilder.Entity("FinalProject.Models.Character", b =>
                {
                    b.HasOne("FinalProject.Models.Weapon", "Weapon")
                        .WithMany("Characters")
                        .HasForeignKey("WeaponId");
                });
#pragma warning restore 612, 618
        }
    }
}