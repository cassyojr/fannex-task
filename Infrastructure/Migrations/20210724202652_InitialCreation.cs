using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    Mileage = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("c0807223-3083-4548-a93a-e47f76c5d519"), "Volkswagen", 100234L, "Golf", 2009 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("f3d6fac5-4790-4442-8eeb-b8e6a206bcf3"), "Volkswagen", 59001L, "Polo", 2010 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("257a8c5d-f245-4729-87aa-2c233773e944"), "Volkswagen", 10234L, "Jetta", 2015 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("3f7f9306-2ad9-4c72-ac39-62636b530a4c"), "Volkswagen", 26050L, "Gol", 2018 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("a46f5ce0-8a6d-401b-a36b-1f9427bf3e78"), "Fiat", 14200L, "Uno", 2019 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("7f71a709-59d3-4daf-931e-3c03cf8abb88"), "Fiat", 5502L, "Argo", 2020 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("84290c09-f58d-4de6-a221-31060fae5260"), "Fiat", 34508L, "Mobi", 2018 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("f3856abd-53f2-443f-ba18-144dc184fa54"), "Fiat", 85745L, "Siena", 2012 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("06fd1c59-a97c-46ce-b7ff-ab95bf651ad5"), "Chevrolet", 66520L, "Cruze", 2018 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("2f0d2710-8f9c-42f7-9781-776867d1b62c"), "Chevrolet", 33200L, "Onix", 2020 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("d922d888-0ee2-4024-a6d8-ed1ee3a6b587"), "Chevrolet", 66504L, "Tracker", 2017 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("ba77451a-2829-4901-8fe7-29095d4b97cf"), "Chevrolet", 468500L, "Spin", 2015 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("c3531139-fe10-4536-94fe-9bcb834948fe"), "Chevrolet", 22500L, "Camaro", 2016 });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "Mileage", "Model", "Year" },
                values: new object[] { new Guid("497a39c6-0b30-422b-882d-cb893eca327a"), "Chevrolet", 56252L, "Cobalt", 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
