﻿// <auto-generated />
using System;
using LibraryAPP.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryAPP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryAPP.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("IsbnNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KitapAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("KutuphanedeMi")
                        .HasColumnType("bit");

                    b.Property<int?>("SayfaSayisi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("YayinlanmaYili")
                        .HasColumnType("datetime2");

                    b.Property<string>("YazarAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("LibraryAPP.Models.BookReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlanKisiAdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlanKisiTcNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlanKisiTelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AlimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("TeslimTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double?>("ToplamAlimSuresi")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("BookReport");
                });

            modelBuilder.Entity("LibraryAPP.Models.BookReport", b =>
                {
                    b.HasOne("LibraryAPP.Models.Book", "Book")
                        .WithMany("BookReport")
                        .HasForeignKey("BookId");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("LibraryAPP.Models.Book", b =>
                {
                    b.Navigation("BookReport");
                });
#pragma warning restore 612, 618
        }
    }
}
