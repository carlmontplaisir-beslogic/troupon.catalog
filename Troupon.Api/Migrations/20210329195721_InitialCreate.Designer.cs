﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Troupon.Catalog.Infra.Persistence;

namespace Troupon.Catalog.Service.Api.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    [Migration("20210329195721_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Troupon.Catalog.Core.Domain.Entities.DealEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MerchantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MerchantId");

                    b.ToTable("Deals");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d53c6ce-6181-42a8-8616-03f86f883112"),
                            Description = "0",
                            Details = "1",
                            MerchantId = new Guid("5e448b39-db5b-42a4-bc12-52f34dcd5c14"),
                            Name = "0"
                        },
                        new
                        {
                            Id = new Guid("4edd43f5-9df4-4cf0-8638-e3fb6f959219"),
                            Description = "1",
                            Details = "0",
                            MerchantId = new Guid("5e448b39-db5b-42a4-bc12-52f34dcd5c14"),
                            Name = "1"
                        },
                        new
                        {
                            Id = new Guid("9319778a-eb57-4c05-80bf-26765e54f1c2"),
                            Description = "2",
                            Details = "0",
                            MerchantId = new Guid("5e448b39-db5b-42a4-bc12-52f34dcd5c14"),
                            Name = "1"
                        },
                        new
                        {
                            Id = new Guid("100300d2-8450-4297-84ca-725b9d1a36c5"),
                            Description = "3",
                            Details = "0",
                            MerchantId = new Guid("5e448b39-db5b-42a4-bc12-52f34dcd5c14"),
                            Name = "1"
                        },
                        new
                        {
                            Id = new Guid("38fed865-a7ba-484b-ad82-7ffa657b6355"),
                            Description = "4",
                            Details = "0",
                            MerchantId = new Guid("532e8ec2-121d-4a86-bfe2-8812c2c27232"),
                            Name = "1"
                        },
                        new
                        {
                            Id = new Guid("dce8acc7-49af-4f89-b35d-29cea76e27ac"),
                            Description = "5",
                            Details = "0",
                            MerchantId = new Guid("532e8ec2-121d-4a86-bfe2-8812c2c27232"),
                            Name = "1"
                        },
                        new
                        {
                            Id = new Guid("dc336a37-8c38-4f49-89d0-279da2471132"),
                            Description = "6",
                            Details = "0",
                            MerchantId = new Guid("83c1dce6-97d5-4a35-afb7-4eb86577160c"),
                            Name = "1"
                        },
                        new
                        {
                            Id = new Guid("9141d48a-fa00-4113-8188-ee8435766972"),
                            Description = "7",
                            Details = "1",
                            MerchantId = new Guid("83c1dce6-97d5-4a35-afb7-4eb86577160c"),
                            Name = "1"
                        });
                });

            modelBuilder.Entity("Troupon.Catalog.Core.Domain.Entities.MerchantEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Merchants");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e448b39-db5b-42a4-bc12-52f34dcd5c14"),
                            Name = "Awsome Goods Plus"
                        },
                        new
                        {
                            Id = new Guid("532e8ec2-121d-4a86-bfe2-8812c2c27232"),
                            Name = "Masso Relax Inc"
                        },
                        new
                        {
                            Id = new Guid("83c1dce6-97d5-4a35-afb7-4eb86577160c"),
                            Name = "Antirouille la magouille"
                        },
                        new
                        {
                            Id = new Guid("042038de-1e60-427d-bdce-7d683ffc8bf5"),
                            Name = "Bronsage & Debosselage Reuni"
                        });
                });

            modelBuilder.Entity("Troupon.Catalog.Core.Domain.Entities.DealEntity", b =>
                {
                    b.HasOne("Troupon.Catalog.Core.Domain.Entities.MerchantEntity", "Merchant")
                        .WithMany("Deals")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Merchant");
                });

            modelBuilder.Entity("Troupon.Catalog.Core.Domain.Entities.MerchantEntity", b =>
                {
                    b.Navigation("Deals");
                });
#pragma warning restore 612, 618
        }
    }
}
