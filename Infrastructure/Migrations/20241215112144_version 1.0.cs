using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class version10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchant",
                columns: table => new
                {
                    MerchantId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MerchantName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MerchantWebLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MerchantWebUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MerchantReturnUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SerectKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchant", x => x.MerchantId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentDestination",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DesLogo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DesShortName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DesName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DesSortIndex = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDestination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PaymentConent = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PaymentCurrency = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PaymentRefId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RequiredAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentLanguage = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PaidAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PaymentLastMessage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MechantId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantId = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    PaymentDestinationId = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Merchant_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchant",
                        principalColumn: "MerchantId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentDestination_PaymentDestinationId",
                        column: x => x.PaymentDestinationId,
                        principalTable: "PaymentDestination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentNotification",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PaymentRefId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NotiDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotiAmount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotiContent = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotiMessage = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotiSignature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotiStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NotiResDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentNotification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentNotification_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentSignature",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SignValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SignAlgo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SignDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SignOwn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentSignature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentSignature_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTransaction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranMessage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TranPayload = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TranStatus = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTransaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTransaction_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_MerchantId",
                table: "Payment",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentDestinationId",
                table: "Payment",
                column: "PaymentDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentNotification_PaymentId",
                table: "PaymentNotification",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentSignature_PaymentId",
                table: "PaymentSignature",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTransaction_PaymentId",
                table: "PaymentTransaction",
                column: "PaymentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentNotification");

            migrationBuilder.DropTable(
                name: "PaymentSignature");

            migrationBuilder.DropTable(
                name: "PaymentTransaction");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Merchant");

            migrationBuilder.DropTable(
                name: "PaymentDestination");
        }
    }
}
