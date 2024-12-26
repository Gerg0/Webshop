using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedVatsItemsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Vats_VatId",
                table: "Items");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Vats_VatId",
                table: "Items",
                column: "VatId",
                principalTable: "Vats",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Vats_VatId",
                table: "Items");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Vats_VatId",
                table: "Items",
                column: "VatId",
                principalTable: "Vats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
