using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KwikTicMaterialBatch.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreMaterialSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialID", "AllUsed", "CreatedBy", "CreatedOn", "KitId", "LastModifiedBy", "LastModifiedOn", "MaterialDescription", "MaterialName", "MaterialSerialNumber", "Quantity" },
                values: new object[,]
                {
                    { 3, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "1mH Inductor Coil", "Inductor-1mH", "SN-0003", 150 },
                    { 4, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "General Purpose Diode", "Diode-1N4007", "SN-0004", 600 },
                    { 5, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "NPN Bipolar Junction Transistor", "Transistor-BC547", "SN-0005", 250 },
                    { 6, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "5mm Red LED", "LED-Red", "SN-0006", 1000 },
                    { 7, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Timer IC NE555", "IC-NE555", "SN-0007", 200 },
                    { 8, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Male Header Pins 40-pin", "Connector-Header", "SN-0008", 350 },
                    { 9, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Mini Toggle Switch SPDT", "Switch-Toggle", "SN-0009", 120 },
                    { 10, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "10K Rotary Potentiometer", "Potentiometer-10K", "SN-0010", 180 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialID",
                keyValue: 10);
        }
    }
}
