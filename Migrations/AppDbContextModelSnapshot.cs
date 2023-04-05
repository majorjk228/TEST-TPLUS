﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TEST_TPLUS.Domains;

#nullable disable

namespace TEST_TPLUS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.House", b =>
                {
                    b.Property<int>("ConsumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumerId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConsumerId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.HouseConsumption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Consumption")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HouseConsumerId")
                        .HasColumnType("int");

                    b.Property<double>("Weather")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("HouseConsumerId");

                    b.ToTable("HouseConsumptions");
                });

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.Plant", b =>
                {
                    b.Property<int>("ConsumerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumerId"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConsumerId");

                    b.ToTable("Plants");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Plant");
                });

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.PlantConsumption", b =>
                {
                    b.HasBaseType("TEST_TPLUS.Domain.Entities.Plant");

                    b.Property<float>("Consumption")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PlantConsumerId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasIndex("PlantConsumerId");

                    b.HasDiscriminator().HasValue("PlantConsumption");
                });

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.HouseConsumption", b =>
                {
                    b.HasOne("TEST_TPLUS.Domain.Entities.House", "House")
                        .WithMany("Consumptions")
                        .HasForeignKey("HouseConsumerId");

                    b.Navigation("House");
                });

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.PlantConsumption", b =>
                {
                    b.HasOne("TEST_TPLUS.Domain.Entities.Plant", null)
                        .WithMany("Consumptionss")
                        .HasForeignKey("PlantConsumerId");
                });

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.House", b =>
                {
                    b.Navigation("Consumptions");
                });

            modelBuilder.Entity("TEST_TPLUS.Domain.Entities.Plant", b =>
                {
                    b.Navigation("Consumptionss");
                });
#pragma warning restore 612, 618
        }
    }
}
