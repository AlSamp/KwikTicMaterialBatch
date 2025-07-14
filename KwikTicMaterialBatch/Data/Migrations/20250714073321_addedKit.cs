using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikTicMaterialBatch.Migrations
{
    /// <inheritdoc />
    public partial class addedKit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Kit_KitId",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kit",
                table: "Kit");

            migrationBuilder.RenameTable(
                name: "Kit",
                newName: "Kits");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Kits",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Kits",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedBy",
                table: "Kits",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedOn",
                table: "Kits",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kits",
                table: "Kits",
                column: "KitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Kits_KitId",
                table: "Materials",
                column: "KitId",
                principalTable: "Kits",
                principalColumn: "KitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Kits_KitId",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kits",
                table: "Kits");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Kits");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Kits");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Kits");

            migrationBuilder.DropColumn(
                name: "LastModifiedOn",
                table: "Kits");

            migrationBuilder.RenameTable(
                name: "Kits",
                newName: "Kit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kit",
                table: "Kit",
                column: "KitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Kit_KitId",
                table: "Materials",
                column: "KitId",
                principalTable: "Kit",
                principalColumn: "KitId");
        }
    }
}
