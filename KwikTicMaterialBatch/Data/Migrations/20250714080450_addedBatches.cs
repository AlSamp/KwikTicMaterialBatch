using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KwikTicMaterialBatch.Migrations
{
    /// <inheritdoc />
    public partial class addedBatches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatchMaterial_Batch_BatchesBatchID",
                table: "BatchMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batch",
                table: "Batch");

            migrationBuilder.RenameTable(
                name: "Batch",
                newName: "Batches");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batches",
                table: "Batches",
                column: "BatchID");

            migrationBuilder.AddForeignKey(
                name: "FK_BatchMaterial_Batches_BatchesBatchID",
                table: "BatchMaterial",
                column: "BatchesBatchID",
                principalTable: "Batches",
                principalColumn: "BatchID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatchMaterial_Batches_BatchesBatchID",
                table: "BatchMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batches",
                table: "Batches");

            migrationBuilder.RenameTable(
                name: "Batches",
                newName: "Batch");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batch",
                table: "Batch",
                column: "BatchID");

            migrationBuilder.AddForeignKey(
                name: "FK_BatchMaterial_Batch_BatchesBatchID",
                table: "BatchMaterial",
                column: "BatchesBatchID",
                principalTable: "Batch",
                principalColumn: "BatchID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
