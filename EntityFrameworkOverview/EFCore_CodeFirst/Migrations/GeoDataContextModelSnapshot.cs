﻿// <auto-generated />
using System;
using EFCore_CodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore_CodeFirst.Migrations
{
    [DbContext(typeof(GeoDataContext))]
    partial class GeoDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCore_CodeFirst.Entities.Continent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CapitalCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContinentId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.CountryLanguages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int?>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<int>("Percent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("LanguagesId");

                    b.ToTable("CountryLanguages");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.Languages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.Country", b =>
                {
                    b.HasOne("EFCore_CodeFirst.Entities.Continent", "ParentContinent")
                        .WithMany("Countries")
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentContinent");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.CountryLanguages", b =>
                {
                    b.HasOne("EFCore_CodeFirst.Entities.Country", "Country")
                        .WithMany("CountryLanguages")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore_CodeFirst.Entities.Languages", "Languages")
                        .WithMany("CountryLanguages")
                        .HasForeignKey("LanguagesId");

                    b.Navigation("Country");

                    b.Navigation("Languages");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.Continent", b =>
                {
                    b.Navigation("Countries");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.Country", b =>
                {
                    b.Navigation("CountryLanguages");
                });

            modelBuilder.Entity("EFCore_CodeFirst.Entities.Languages", b =>
                {
                    b.Navigation("CountryLanguages");
                });
#pragma warning restore 612, 618
        }
    }
}
