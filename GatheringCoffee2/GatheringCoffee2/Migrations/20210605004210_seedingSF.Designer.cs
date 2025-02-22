﻿// <auto-generated />
using System;
using GatheringCoffee2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GatheringCoffee2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605004210_seedingSF")]
    partial class seedingSF
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GatheringCoffee2.Models.CoffeeCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CoffeeCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hot Coffee"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cold Coffee"
                        });
                });

            modelBuilder.Entity("GatheringCoffee2.Models.CoffeeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CoffeeCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CoffeeCategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Coffee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoffeeCategoryId = 1,
                            Description = "the V60 is one of specialty coffee’s favourite brewing methods. Within 3 minutes, you can brew an incredibly tasty coffee.",
                            Image = "/img/V60.jpeg",
                            Name = "V60",
                            Price = 18f
                        },
                        new
                        {
                            Id = 2,
                            CoffeeCategoryId = 1,
                            Description = "the Chemex will give you a remarkably clean cup of coffee",
                            Image = "/img/Chemix.jpeg",
                            Name = "Chemix",
                            Price = 17f
                        },
                        new
                        {
                            Id = 3,
                            CoffeeCategoryId = 1,
                            Description = "Amazing milky coffie where the milk is more than the coffie",
                            Image = "/img/Latte.jpeg",
                            Name = "Latte",
                            Price = 15f
                        },
                        new
                        {
                            Id = 4,
                            CoffeeCategoryId = 1,
                            Description = "Amazing milky coffie where the milk is more than the coffie",
                            Image = "/img/Espresso.jpeg",
                            Name = "Espresso",
                            Price = 11f
                        },
                        new
                        {
                            Id = 5,
                            CoffeeCategoryId = 1,
                            Description = "Amazing milky coffie where the coffie is more than the milk",
                            Image = "/img/Cortado.jpeg",
                            Name = "Cortado",
                            Price = 14f
                        },
                        new
                        {
                            Id = 6,
                            CoffeeCategoryId = 2,
                            Description = "The best sweet drink available right now ",
                            Image = "/img/Spanish-Latte.jpeg",
                            Name = "Spanish-Latte",
                            Price = 16f
                        },
                        new
                        {
                            Id = 7,
                            CoffeeCategoryId = 2,
                            Description = "The 2nd best sweet drink available right now",
                            Image = "/img/Honey-Latte.jpeg",
                            Name = "Honey-Latte",
                            Price = 16f
                        },
                        new
                        {
                            Id = 8,
                            CoffeeCategoryId = 2,
                            Description = "The daily favourite drink ",
                            Image = "/img/ColdPro.jpeg",
                            Name = "ColdPro",
                            Price = 21f
                        },
                        new
                        {
                            Id = 9,
                            CoffeeCategoryId = 2,
                            Description = "beautifully assembled summer drink where the strawberry is the main ingrediant",
                            Image = "/img/Strawberry-Moheto.jpeg",
                            Name = "Strawberry-Moheto",
                            Price = 15f
                        },
                        new
                        {
                            Id = 10,
                            CoffeeCategoryId = 2,
                            Description = "beautifully assembled summer drink where the lemon is the main ingrediant",
                            Image = "/img/Lemon-Moheto.jpeg",
                            Name = "Lemon-Moheto",
                            Price = 15f
                        });
                });

            modelBuilder.Entity("GatheringCoffee2.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("GatheringCoffee2.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Order");
                });

            modelBuilder.Entity("GatheringCoffee2.Models.SweetAndFoodCategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SweetAndFoodCategory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sweet"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Food"
                        });
                });

            modelBuilder.Entity("GatheringCoffee2.Models.SweetAndFoodModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SweetAndFoodCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SweetAndFoodCategoryId");

                    b.ToTable("SweetAndFood");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is the nice Pistachio cake",
                            Image = "/img/Pistachio-cake.jpeg",
                            Name = "Pistachio-cake",
                            Price = 28f,
                            SweetAndFoodCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is the nice Brawn cake",
                            Image = "/img/Brown-cake.jpeg",
                            Name = "Brown-cake",
                            Price = 23f,
                            SweetAndFoodCategoryId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is the nice Tiramisu Cake",
                            Image = "/img/Tiramisu-Cake.jpg",
                            Name = "Tiramisu-Cake",
                            Price = 25f,
                            SweetAndFoodCategoryId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is the nice Haloumi-Sandwish It consists of halloumi added to it, tomatoes, olive oil and thyme",
                            Image = "/img/Haloumi-Sandwish.jpeg",
                            Name = "Haloumi-Sandwish",
                            Price = 20f,
                            SweetAndFoodCategoryId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is the nice Croissant It consists of nice cheese",
                            Image = "/img/Croissant.jpeg",
                            Name = "Croissant",
                            Price = 14f,
                            SweetAndFoodCategoryId = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "This is the nice Croissant It consists of nice Labnah dich and Egg dich ",
                            Image = "/img/Break-Fast.jpeg",
                            Name = "Break-Fast",
                            Price = 30f,
                            SweetAndFoodCategoryId = 2
                        });
                });

            modelBuilder.Entity("GatheringCoffee2.Models.CoffeeModel", b =>
                {
                    b.HasOne("GatheringCoffee2.Models.CoffeeCategoryModel", "CoffeeCategory")
                        .WithMany("Coffee")
                        .HasForeignKey("CoffeeCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GatheringCoffee2.Models.OrderModel", "Order")
                        .WithMany("Coffee")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("GatheringCoffee2.Models.OrderModel", b =>
                {
                    b.HasOne("GatheringCoffee2.Models.CustomerModel", "Customer")
                        .WithOne("Order")
                        .HasForeignKey("GatheringCoffee2.Models.OrderModel", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GatheringCoffee2.Models.SweetAndFoodModel", b =>
                {
                    b.HasOne("GatheringCoffee2.Models.OrderModel", "Order")
                        .WithMany("SweetAndFood")
                        .HasForeignKey("OrderId");

                    b.HasOne("GatheringCoffee2.Models.SweetAndFoodCategoryModel", "SweetAndFoodCategory")
                        .WithMany("SweetAndFood")
                        .HasForeignKey("SweetAndFoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
