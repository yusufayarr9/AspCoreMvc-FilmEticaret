﻿// <auto-generated />
using System;
using AspNetCoreMvc_eTicaret_MovieSales.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AspNetCoreMvc_eTicaret_MovieSales.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20241225203441_yusuf")]
    partial class yusuf
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Beşiktaş-İstanbul",
                            Email = "aucar@gmail.com",
                            Name = "Ali Uçar",
                            Password = "123",
                            Phone = "543 345 66 77"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Kadıköy-İstanbul",
                            Email = "okosar@gmail.com",
                            Name = "Oya Koşar",
                            Password = "123",
                            Phone = "533 345 66 77"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Bakırköy-İstanbul",
                            Email = "nsever@gmail.com",
                            Name = "Neşe Sever",
                            Password = "123",
                            Phone = "542 345 66 77"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Fatih-İstanbul",
                            Email = "hkaya@gmail.com",
                            Name = "Hasan Kaya",
                            Password = "123",
                            Phone = "535 345 66 77"
                        });
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Komik olaylar",
                            Name = "Komedi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Tarihi savaşlar",
                            Name = "Savaş"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Hem romantik hem komik",
                            Name = "Romantik Komedi"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Acıklı hikayeler",
                            Name = "Dram"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Korku, gerilim",
                            Name = "Korku"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Uzay, robotlar",
                            Name = "Bilim Kurgu"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Gerçek dışı, heyecanlı",
                            Name = "Fantastik"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Hareket, aksiyon sahneleri",
                            Name = "Aksiyon"
                        });
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cast")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("/images/filmadi.jpg");

                    b.Property<bool>("IsLocal")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPopuler")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cast = "Bradd Pitt, Orlando Bloom",
                            Director = "Wolfgan Pettersen",
                            GenreId = 2,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Truva",
                            Price = 450m,
                            ReleaseDate = new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2143),
                            Stock = 5,
                            Summary = "Tarihi Truva savaşından kesitler"
                        },
                        new
                        {
                            Id = 2,
                            Cast = "Annda George, Donny Alamsyah",
                            Director = "Gareth Evans",
                            GenreId = 8,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Baskın",
                            Price = 400m,
                            ReleaseDate = new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2159),
                            Stock = 6,
                            Summary = "Operasyon timinin uyuşturucu baskınları"
                        },
                        new
                        {
                            Id = 3,
                            Cast = "Leonardo Di Caprio, Cate Winslet",
                            Director = "James Cameron",
                            GenreId = 4,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Titanic",
                            Price = 500m,
                            ReleaseDate = new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2161),
                            Stock = 15,
                            Summary = "Lüks titanic gemisinin hazin öyküsü"
                        },
                        new
                        {
                            Id = 4,
                            Cast = "Bradd Pitt, Edward Norton",
                            Director = "David Lyinch",
                            GenreId = 8,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Fight Club",
                            Price = 450m,
                            ReleaseDate = new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2163),
                            Stock = 5,
                            Summary = "Dövüş kulübü, ilk kural bahsetmemek"
                        },
                        new
                        {
                            Id = 5,
                            Cast = "Bradd Pitt, Christoph Walls",
                            Director = "Quantin Tarantino",
                            GenreId = 2,
                            IsLocal = false,
                            IsPopuler = false,
                            Name = "Soysuzlar Çetesi",
                            Price = 520m,
                            ReleaseDate = new DateTime(2024, 12, 25, 23, 34, 36, 428, DateTimeKind.Local).AddTicks(2164),
                            Stock = 10,
                            Summary = "2. Dünya savaşından kesitler"
                        });
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.MovieSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("MovieSales");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.MovieSaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("MovieSaleId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("MovieSaleId");

                    b.ToTable("MovieSaleDetails");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.ViewModels.CustomerViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerViewModel");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.Movie", b =>
                {
                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Entities.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.MovieSale", b =>
                {
                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Entities.Customer", "Customer")
                        .WithMany("MovieSales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.MovieSaleDetail", b =>
                {
                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Entities.Movie", "Movie")
                        .WithMany("MovieSaleDetails")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetCoreMvc_eTicaret_MovieSales.Entities.MovieSale", "MovieSale")
                        .WithMany("MovieSaleDetails")
                        .HasForeignKey("MovieSaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("MovieSale");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.Customer", b =>
                {
                    b.Navigation("MovieSales");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.Movie", b =>
                {
                    b.Navigation("MovieSaleDetails");
                });

            modelBuilder.Entity("AspNetCoreMvc_eTicaret_MovieSales.Entities.MovieSale", b =>
                {
                    b.Navigation("MovieSaleDetails");
                });
#pragma warning restore 612, 618
        }
    }
}