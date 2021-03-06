﻿// <auto-generated />
using System;
using EntityYazar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityForeignKey.Migrations
{
    [DbContext(typeof(KitapDbContext))]
    partial class KitapDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("EntityYazar.Kitap", b =>
                {
                    b.Property<int>("KitapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KitapAdi")
                        .HasColumnType("TEXT");

                    b.Property<int?>("YazarId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KitapId");

                    b.HasIndex("YazarId");

                    b.ToTable("kitaplar");
                });

            modelBuilder.Entity("EntityYazar.Yazar", b =>
                {
                    b.Property<int>("YazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("YazarAdi")
                        .HasColumnType("TEXT");

                    b.HasKey("YazarId");

                    b.ToTable("yazarlar");
                });

            modelBuilder.Entity("EntityYazar.Kitap", b =>
                {
                    b.HasOne("EntityYazar.Yazar", null)
                        .WithMany("Kitaplar")
                        .HasForeignKey("YazarId");
                });
#pragma warning restore 612, 618
        }
    }
}
