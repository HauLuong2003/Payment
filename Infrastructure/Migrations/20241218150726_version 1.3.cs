using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class version13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentTransaction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaymentTransaction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "PaymentTransaction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByy",
                table: "PaymentTransaction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentSignature",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaymentSignature",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "PaymentSignature",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByy",
                table: "PaymentSignature",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentNotification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaymentNotification",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "PaymentNotification",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByy",
                table: "PaymentNotification",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PaymentDestination",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PaymentDestination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "PaymentDestination",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByy",
                table: "PaymentDestination",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "Payment",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByy",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Merchant",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Merchant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "Merchant",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByy",
                table: "Merchant",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PaymentTransaction");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaymentTransaction");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "PaymentTransaction");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByy",
                table: "PaymentTransaction");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PaymentSignature");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaymentSignature");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "PaymentSignature");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByy",
                table: "PaymentSignature");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PaymentNotification");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaymentNotification");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "PaymentNotification");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByy",
                table: "PaymentNotification");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PaymentDestination");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PaymentDestination");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "PaymentDestination");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByy",
                table: "PaymentDestination");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByy",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Merchant");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Merchant");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "Merchant");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByy",
                table: "Merchant");
        }
    }
}
