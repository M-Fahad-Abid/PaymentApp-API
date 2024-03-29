﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentAPI.Data;

#nullable disable

namespace PaymentAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PaymentAPI.Models.PaymentDetail", b =>
                {
                    b.Property<int>("PaymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentDetailId"));

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CardOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SecurityCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("PaymentDetailId");

                    b.ToTable("PaymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
