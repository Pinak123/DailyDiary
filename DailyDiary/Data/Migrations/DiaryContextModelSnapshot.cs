﻿// <auto-generated />
using System;
using DailyDiary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DailyDiary.Data.Migrations
{
    [DbContext(typeof(DiaryContext))]
    partial class DiaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DailyDiary.Models.Diary", b =>
                {
                    b.Property<int>("SrNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Diary_Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Diary_Entry_Date")
                        .HasColumnType("TEXT");

                    b.HasKey("SrNo");

                    b.ToTable("Diary");
                });
#pragma warning restore 612, 618
        }
    }
}
