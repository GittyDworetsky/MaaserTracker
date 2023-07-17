﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReactMaaserTracker.Data;

#nullable disable

namespace ReactMaaserTracker.Data.Migrations
{
    [DbContext(typeof(ReactMaaserTrackerDataContext))]
    [Migration("20230717155011_added list props to incomes and incomesources")]
    partial class addedlistpropstoincomesandincomesources
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IncomeIncomeSource", b =>
                {
                    b.Property<int>("IncomeSourcesId")
                        .HasColumnType("int");

                    b.Property<int>("IncomesId")
                        .HasColumnType("int");

                    b.HasKey("IncomeSourcesId", "IncomesId");

                    b.HasIndex("IncomesId");

                    b.ToTable("IncomeIncomeSource");
                });

            modelBuilder.Entity("ReactMaaserTracker.Data.Income", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateSubmitted")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncomeSourceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("IncomeDeposits");
                });

            modelBuilder.Entity("ReactMaaserTracker.Data.IncomeSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncomeSources");
                });

            modelBuilder.Entity("ReactMaaserTracker.Data.MaaserDeposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Recipient")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MaaserDeposits");
                });

            modelBuilder.Entity("IncomeIncomeSource", b =>
                {
                    b.HasOne("ReactMaaserTracker.Data.IncomeSource", null)
                        .WithMany()
                        .HasForeignKey("IncomeSourcesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReactMaaserTracker.Data.Income", null)
                        .WithMany()
                        .HasForeignKey("IncomesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
