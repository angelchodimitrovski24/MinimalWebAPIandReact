﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinimalWebApi.Data;

#nullable disable

namespace MinimalWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MinimalWebApi.Models.Payment", b =>
                {
                    b.Property<string>("PaymentId")
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            PaymentId = "pay_1",
                            Amount = 10.00m,
                            Currency = "USD",
                            Status = "Paid"
                        },
                        new
                        {
                            PaymentId = "pay_2",
                            Amount = 20.00m,
                            Currency = "USD",
                            Status = "Paid"
                        },
                        new
                        {
                            PaymentId = "pay_3",
                            Amount = 30.00m,
                            Currency = "USD",
                            Status = "Paid"
                        });
                });

            modelBuilder.Entity("MinimalWebApi.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = "prod_1",
                            Name = "Product 1",
                            Price = 10.00m
                        },
                        new
                        {
                            ProductId = "prod_2",
                            Name = "Product 2",
                            Price = 20.00m
                        },
                        new
                        {
                            ProductId = "prod_3",
                            Name = "Product 3",
                            Price = 30.00m
                        });
                });

            modelBuilder.Entity("MinimalWebApi.Models.Transaction", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TransactionId");

                    b.HasIndex("PaymentId");

                    b.HasIndex("ProductId");

                    b.ToTable("Transactions");

                    b.HasData(
                        new
                        {
                            TransactionId = "txn_1",
                            PaymentId = "pay_1",
                            ProductId = "prod_1",
                            Status = "Completed"
                        },
                        new
                        {
                            TransactionId = "txn_2",
                            PaymentId = "pay_2",
                            ProductId = "prod_2",
                            Status = "Completed"
                        },
                        new
                        {
                            TransactionId = "txn_3",
                            PaymentId = "pay_3",
                            ProductId = "prod_3",
                            Status = "Completed"
                        });
                });

            modelBuilder.Entity("MinimalWebApi.Models.Transaction", b =>
                {
                    b.HasOne("MinimalWebApi.Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MinimalWebApi.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
