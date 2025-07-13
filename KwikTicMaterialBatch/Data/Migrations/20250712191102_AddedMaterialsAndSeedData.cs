using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KwikTicMaterialBatch.Migrations
{
    /// <inheritdoc />
    public partial class AddedMaterialsAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    BatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatchName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => x.BatchID);
                });

            migrationBuilder.CreateTable(
                name: "Kit",
                columns: table => new
                {
                    KitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kit", x => x.KitId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialSerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    AllUsed = table.Column<bool>(type: "bit", nullable: true),
                    KitId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialID);
                    table.ForeignKey(
                        name: "FK_Materials_Kit_KitId",
                        column: x => x.KitId,
                        principalTable: "Kit",
                        principalColumn: "KitId");
                });

            migrationBuilder.CreateTable(
                name: "BatchMaterial",
                columns: table => new
                {
                    BatchesBatchID = table.Column<int>(type: "int", nullable: false),
                    MaterialsMaterialID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatchMaterial", x => new { x.BatchesBatchID, x.MaterialsMaterialID });
                    table.ForeignKey(
                        name: "FK_BatchMaterial_Batch_BatchesBatchID",
                        column: x => x.BatchesBatchID,
                        principalTable: "Batch",
                        principalColumn: "BatchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatchMaterial_Materials_MaterialsMaterialID",
                        column: x => x.MaterialsMaterialID,
                        principalTable: "Materials",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialID", "AllUsed", "CreatedBy", "CreatedOn", "KitId", "LastModifiedBy", "LastModifiedOn", "MaterialDescription", "MaterialName", "MaterialSerialNumber", "Quantity" },
                values: new object[,]
                {
                    { 1, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "10K Ohm Resistor", "Resistor-10K", "SN-0001", 500 },
                    { 2, false, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "100uF Electrolytic Capacitor", "Capacitor-100uF", "SN-0002", 300 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatchMaterial_MaterialsMaterialID",
                table: "BatchMaterial",
                column: "MaterialsMaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_KitId",
                table: "Materials",
                column: "KitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatchMaterial");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Kit");
        }
    }
}
