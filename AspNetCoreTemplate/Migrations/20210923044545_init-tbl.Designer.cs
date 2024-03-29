﻿// <auto-generated />

using AspNetCoreTemplate.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AspNetCoreTemplate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210923044545_init-tbl")]
    partial class inittbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("AspNetCoreTemplate.Domain.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("author");

                    b.Property<string>("KindOfMusic")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("kind_of_music");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric")
                        .HasColumnName("rating");

                    b.Property<int>("View")
                        .HasColumnType("integer")
                        .HasColumnName("view");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("d_songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Sơn Tùng MTP",
                            KindOfMusic = "Pop",
                            Name = "Lạc trôi",
                            Rating = 4.6m,
                            View = 120000
                        },
                        new
                        {
                            Id = 2,
                            Author = "Lê Bảo Bình",
                            KindOfMusic = "Nhạc Trẻ",
                            Name = "Sai cách yêu",
                            Rating = 4.2m,
                            View = 45000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
