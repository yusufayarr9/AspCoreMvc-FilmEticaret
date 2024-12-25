using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCoreMvc_eTicaret_MovieSales.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cast = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "/images/filmadi.jpg"),
                    IsLocal = table.Column<bool>(type: "bit", nullable: false),
                    IsPopuler = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieSaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieSaleId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieSaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSaleDetails_MovieSales_MovieSaleId",
                        column: x => x.MovieSaleId,
                        principalTable: "MovieSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieSaleDetails_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Beşiktaş-İstanbul", "aucar@gmail.com", "Ali Uçar", "123", "543 345 66 77" },
                    { 2, "Kadıköy-İstanbul", "okosar@gmail.com", "Oya Koşar", "123", "533 345 66 77" },
                    { 3, "Bakırköy-İstanbul", "nsever@gmail.com", "Neşe Sever", "123", "542 345 66 77" },
                    { 4, "Fatih-İstanbul", "hkaya@gmail.com", "Hasan Kaya", "123", "535 345 66 77" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Komik olaylar", "Komedi" },
                    { 2, "Tarihi savaşlar", "Savaş" },
                    { 3, "Hem romantik hem komik", "Romantik Komedi" },
                    { 4, "Acıklı hikayeler", "Dram" },
                    { 5, "Korku, gerilim", "Korku" },
                    { 6, "Uzay, robotlar", "Bilim Kurgu" },
                    { 7, "Gerçek dışı, heyecanlı", "Fantastik" },
                    { 8, "Hareket, aksiyon sahneleri", "Aksiyon" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Cast", "Director", "GenreId", "IsLocal", "Name", "Price", "ReleaseDate", "Stock", "Summary" },
                values: new object[,]
                {
                    { 1, "Bradd Pitt, Orlando Bloom", "Wolfgan Pettersen", 2, false, "Truva", 450m, new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8926), 5, "Tarihi Truva savaşından kesitler" },
                    { 2, "Annda George, Donny Alamsyah", "Gareth Evans", 8, false, "Baskın", 400m, new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8942), 6, "Operasyon timinin uyuşturucu baskınları" },
                    { 3, "Leonardo Di Caprio, Cate Winslet", "James Cameron", 4, false, "Titanic", 500m, new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8944), 15, "Lüks titanic gemisinin hazin öyküsü" },
                    { 4, "Bradd Pitt, Edward Norton", "David Lyinch", 8, false, "Fight Club", 450m, new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8946), 5, "Dövüş kulübü, ilk kural bahsetmemek" },
                    { 5, "Bradd Pitt, Christoph Walls", "Quantin Tarantino", 2, false, "Soysuzlar Çetesi", 520m, new DateTime(2024, 8, 3, 10, 37, 11, 921, DateTimeKind.Local).AddTicks(8948), 10, "2. Dünya savaşından kesitler" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSaleDetails_MovieId",
                table: "MovieSaleDetails",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSaleDetails_MovieSaleId",
                table: "MovieSaleDetails",
                column: "MovieSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSales_CustomerId",
                table: "MovieSales",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerViewModel");

            migrationBuilder.DropTable(
                name: "MovieSaleDetails");

            migrationBuilder.DropTable(
                name: "MovieSales");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
