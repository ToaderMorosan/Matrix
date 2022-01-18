﻿// <auto-generated />
using System;
using Matrix.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Matrix.Migrations
{
    [DbContext(typeof(SkillMatrixContext))]
    partial class SkillMatrixContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Matrix.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ocupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("github")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("instagram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Description = "llllllllll",
                            Name = "llllllllll",
                            Ocupation = "llllllllll",
                            PhoneNumber = "llllllllll",
                            address = "llllllllll",
                            email = "llllllllll",
                            github = "llllllllll",
                            instagram = "llllllllll"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            Description = "llllllllll",
                            Name = "kkkkkkkkkk",
                            Ocupation = "kkkkkkkkkk",
                            PhoneNumber = "kkkkkkkkkk",
                            address = "kkkkkkkkkk",
                            email = "kkkkkkkkkk",
                            github = "kkkkkkkkkk",
                            instagram = "kkkkkkkkkk"
                        },
                        new
                        {
                            Id = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            Description = "llllllllll",
                            Name = "jjjjjjjjjjj",
                            Ocupation = "jjjjjjjjjjj",
                            PhoneNumber = "jjjjjjjjjjj",
                            address = "jjjjjjjjjjj",
                            email = "jjjjjjjjjjj",
                            github = "jjjjjjjjjjj",
                            instagram = "jjjjjjjjjjj"
                        },
                        new
                        {
                            Id = new Guid("102b566b-ba1f-404c-b2df-e2cde39ade09"),
                            Description = "llllllllll",
                            Name = "iiiiiii",
                            Ocupation = "iiiiiii",
                            PhoneNumber = "iiiiiii",
                            address = "iiiiiii",
                            email = "iiiiiii",
                            github = "iiiiiii",
                            instagram = "iiiiiii"
                        },
                        new
                        {
                            Id = new Guid("5b3621c0-7b12-4e80-9c8b-3398cba7ee05"),
                            Description = "llllllllll",
                            Name = "hhhhhhhhh",
                            Ocupation = "hhhhhhhhh",
                            PhoneNumber = "hhhhhhhhh",
                            address = "hhhhhhhhh",
                            email = "hhhhhhhhh",
                            github = "hhhhhhhhh",
                            instagram = "hhhhhhhhh"
                        },
                        new
                        {
                            Id = new Guid("2aadd2df-7caf-45ab-9355-7f6332985a87"),
                            Description = "llllllllll",
                            Name = "gggggggg",
                            Ocupation = "gggggggg",
                            PhoneNumber = "gggggggg",
                            address = "gggggggg",
                            email = "gggggggg",
                            github = "gggggggg",
                            instagram = "gggggggg"
                        },
                        new
                        {
                            Id = new Guid("2ee49fe3-edf2-4f91-8409-3eb25ce6ca51"),
                            Description = "llllllllll",
                            Name = "fffffffffffff",
                            Ocupation = "fffffffffffff",
                            PhoneNumber = "fffffffffffff",
                            address = "fffffffffffff",
                            email = "fffffffffffff",
                            github = "fffffffffffff",
                            instagram = "fffffffffffff"
                        },
                        new
                        {
                            Id = new Guid("71838f8b-6ab3-4539-9e67-4e77b8ede1c0"),
                            Description = "llllllllll",
                            Name = "eeeeeeee",
                            Ocupation = "eeeeeeee",
                            PhoneNumber = "eeeeeeee",
                            address = "eeeeeeee",
                            email = "eeeeeeee",
                            github = "eeeeeeee",
                            instagram = "eeeeeeee"
                        },
                        new
                        {
                            Id = new Guid("119f9ccb-149d-4d3c-ad4f-40100f38e918"),
                            Description = "llllllllll",
                            Name = "ddddddddd",
                            Ocupation = "ddddddddd",
                            PhoneNumber = "ddddddddd",
                            address = "ddddddddd",
                            email = "ddddddddd",
                            github = "ddddddddd",
                            instagram = "ddddddddd"
                        },
                        new
                        {
                            Id = new Guid("28c1db41-f104-46e6-8943-d31c0291e0e3"),
                            Description = "llllllllll",
                            Name = "cccccccccc",
                            Ocupation = "cccccccccc",
                            PhoneNumber = "cccccccccc",
                            address = "cccccccccc",
                            email = "cccccccccc",
                            github = "cccccccccc",
                            instagram = "cccccccccc"
                        },
                        new
                        {
                            Id = new Guid("d94a64c2-2e8f-4162-9976-0ffe03d30767"),
                            Description = "llllllllll",
                            Name = "bbbbbbbbbb",
                            Ocupation = "bbbbbbbbbb",
                            PhoneNumber = "bbbbbbbbbb",
                            address = "bbbbbbbbbb",
                            email = "bbbbbbbbbb",
                            github = "bbbbbbbbbb",
                            instagram = "bbbbbbbbbb"
                        },
                        new
                        {
                            Id = new Guid("380c2c6b-0d1c-4b82-9d83-3cf635a3e62b"),
                            Description = "llllllllll",
                            Name = "aaaaaaaaa",
                            Ocupation = "aaaaaaaaa",
                            PhoneNumber = "aaaaaaaaa",
                            address = "aaaaaaaaa",
                            email = "aaaaaaaaa",
                            github = "boscaaaaaaaaahetar",
                            instagram = "aaaaaaaaa"
                        });
                });

            modelBuilder.Entity("Matrix.Entities.Study", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Interval")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Studies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            EmployeeId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Interval = "2002-2022",
                            Location = "Commandeering a ship in rough waters isn't easy.  Commandeering it without getting caught is even harder.  In this course you'll learn how to sail away and avoid those pesky musketeers.",
                            Name = "Commandeering a Ship Without Getting Caught"
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            EmployeeId = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Interval = "2002-2022",
                            Location = "In this course, the author provides tips to avoid, or, if needed, overthrow pirate mutiny.",
                            Name = "Overthrowing Mutiny"
                        },
                        new
                        {
                            Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            EmployeeId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            Interval = "2002-2022",
                            Location = "Every good pirate loves rum, but it also has a tendency to get you into trouble.  In this course you'll learn how to avoid that.  This new exclusive edition includes an additional chapter on how to run fast without falling while drunk.",
                            Name = "Avoiding Brawls While Drinking as Much Rum as You Desire"
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            EmployeeId = new Guid("2902b665-1190-4c70-9915-b9c2d7680450"),
                            Interval = "2002-2022",
                            Location = "In this course you'll learn how to sing all-time favourite pirate songs without sounding like you actually know the words or how to hold a note.",
                            Name = "Singalong Pirate Hits"
                        });
                });

            modelBuilder.Entity("Matrix.Entities.Study", b =>
                {
                    b.HasOne("Matrix.Entities.Employee", "Employee")
                        .WithMany("Studies")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Matrix.Entities.Employee", b =>
                {
                    b.Navigation("Studies");
                });
#pragma warning restore 612, 618
        }
    }
}