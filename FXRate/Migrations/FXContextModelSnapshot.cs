﻿// <auto-generated />
using FXRate.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FXRate.Migrations
{
    [DbContext(typeof(FXContext))]
    partial class FXContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FXRate.Infrastructure.FXRateItem", b =>
                {
                    b.Property<int>("FXRateItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FXBase")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FXRateValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FXSymbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FXRateItemId");

                    b.ToTable("FXRateItems");
                });
#pragma warning restore 612, 618
        }
    }
}