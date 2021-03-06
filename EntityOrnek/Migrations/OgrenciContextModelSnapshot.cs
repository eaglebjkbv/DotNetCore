﻿// <auto-generated />
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityOrnek.Migrations
{
    [DbContext(typeof(OgrenciContext))]
    partial class OgrenciContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("Entities.Ogrenci", b =>
                {
                    b.Property<int>("ogrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ad")
                        .HasColumnType("TEXT");

                    b.Property<string>("soyad")
                        .HasColumnType("TEXT");

                    b.HasKey("ogrenciId");

                    b.ToTable("ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}
