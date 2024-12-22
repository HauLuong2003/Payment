using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class version11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_PaymentDestination_ParentId",
                table: "PaymentDestination",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDestination_PaymentDestination_ParentId",
                table: "PaymentDestination",
                column: "ParentId",
                principalTable: "PaymentDestination",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDestination_PaymentDestination_ParentId",
                table: "PaymentDestination");

            migrationBuilder.DropIndex(
                name: "IX_PaymentDestination_ParentId",
                table: "PaymentDestination");
        }
    }
}
