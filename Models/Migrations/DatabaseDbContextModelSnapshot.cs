﻿// <auto-generated />
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(DatabaseDbContext))]
    partial class DatabaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Database.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Line1")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Brynteg",
                            Line1 = "17 Cae Rhos",
                            PersonId = 1,
                            Postcode = "LL78 8JF"
                        },
                        new
                        {
                            Id = 2,
                            City = "Exeter",
                            Line1 = "8 Lonsdale Road",
                            PersonId = 2,
                            Postcode = "EX1 3DW"
                        },
                        new
                        {
                            Id = 3,
                            City = "Brighouse",
                            Line1 = "36 Close Lea",
                            PersonId = 3,
                            Postcode = "HD6 3AR"
                        },
                        new
                        {
                            Id = 4,
                            City = "Bournemouth",
                            Line1 = "14 The Avenue",
                            PersonId = 4,
                            Postcode = "BH2 6LT"
                        },
                        new
                        {
                            Id = 5,
                            City = "Plymouth",
                            Line1 = "22 Oakdale Road",
                            PersonId = 5,
                            Postcode = "PL3 6QN"
                        },
                        new
                        {
                            Id = 6,
                            City = "Newcastle",
                            Line1 = "11 The Crescent",
                            PersonId = 6,
                            Postcode = "NE2 4AU"
                        },
                        new
                        {
                            Id = 7,
                            City = "Leeds",
                            Line1 = "19 The Green",
                            PersonId = 7,
                            Postcode = "LS12 1AQ"
                        },
                        new
                        {
                            Id = 8,
                            City = "Sheffield",
                            Line1 = "25 The Drive",
                            PersonId = 8,
                            Postcode = "S10 2DF"
                        },
                        new
                        {
                            Id = 9,
                            City = "Bristol",
                            Line1 = "30 The Avenue",
                            PersonId = 9,
                            Postcode = "BS6 5BX"
                        },
                        new
                        {
                            Id = 10,
                            City = "Nottingham",
                            Line1 = "42 The Close",
                            PersonId = 10,
                            Postcode = "NG1 4BH"
                        },
                        new
                        {
                            Id = 11,
                            City = "Oxford",
                            Line1 = "15 The Square",
                            PersonId = 11,
                            Postcode = "OX1 1AQ"
                        },
                        new
                        {
                            Id = 12,
                            City = "Cambridge",
                            Line1 = "28 The Street",
                            PersonId = 12,
                            Postcode = "CB2 3TN"
                        },
                        new
                        {
                            Id = 13,
                            City = "London",
                            Line1 = "31 The Lane",
                            PersonId = 13,
                            Postcode = "SW1A 1AA"
                        },
                        new
                        {
                            Id = 14,
                            City = "Manchester",
                            Line1 = "18 The Grove",
                            PersonId = 14,
                            Postcode = "M1 5FN"
                        },
                        new
                        {
                            Id = 15,
                            City = "Birmingham",
                            Line1 = "24 The Rise",
                            PersonId = 15,
                            Postcode = "B1 2EA"
                        },
                        new
                        {
                            Id = 16,
                            City = "Leicester",
                            Line1 = "39 The Hill",
                            PersonId = 16,
                            Postcode = "LE1 5DE"
                        },
                        new
                        {
                            Id = 17,
                            City = "Cardiff",
                            Line1 = "45 The View",
                            PersonId = 17,
                            Postcode = "CF10 1BH"
                        },
                        new
                        {
                            Id = 18,
                            City = "Edinburgh",
                            Line1 = "50 The Way",
                            PersonId = 18,
                            Postcode = "EH1 3YL"
                        },
                        new
                        {
                            Id = 19,
                            City = "Glasgow",
                            Line1 = "55 The Place",
                            PersonId = 19,
                            Postcode = "G1 1XE"
                        },
                        new
                        {
                            Id = 20,
                            City = "Belfast",
                            Line1 = "60 The Street",
                            PersonId = 20,
                            Postcode = "BT1 5GS"
                        });
                });

            modelBuilder.Entity("Database.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("GMC")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Karilynn",
                            GMC = 1169492,
                            LastName = "Rock"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Arlyn",
                            GMC = 8836597,
                            LastName = "Coetzee"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Carly",
                            GMC = 9548968,
                            LastName = "Heeran"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Rae",
                            GMC = 1807233,
                            LastName = "Tuft"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Eugenius",
                            GMC = 3229745,
                            LastName = "Uden"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Constancia",
                            GMC = 7208570,
                            LastName = "Salerno"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Harmon",
                            GMC = 1215810,
                            LastName = "Stent"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Adriano",
                            GMC = 6428880,
                            LastName = "Jull"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Garrek",
                            GMC = 9279644,
                            LastName = "Frenzl"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Letitia",
                            GMC = 3699271,
                            LastName = "Grabert"
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Dulcia",
                            GMC = 4793921,
                            LastName = "Chadbourn"
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Hilliard",
                            GMC = 8854603,
                            LastName = "Glendza"
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "Rena",
                            GMC = 9442324,
                            LastName = "McCarl"
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "Tobiah",
                            GMC = 9488055,
                            LastName = "Wheldon"
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "Morgun",
                            GMC = 2520979,
                            LastName = "Downe"
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "Cullan",
                            GMC = 7708262,
                            LastName = "Weiser"
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "Niles",
                            GMC = 7046029,
                            LastName = "Kief"
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "Randi",
                            GMC = 3086851,
                            LastName = "McLorinan"
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "Virgil",
                            GMC = 3165201,
                            LastName = "Sperry"
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "Hoyt",
                            GMC = 1795805,
                            LastName = "Turbern"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
