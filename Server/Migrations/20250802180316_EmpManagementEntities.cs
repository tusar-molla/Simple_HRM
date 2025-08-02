using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class EmpManagementEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 8, 2, 18, 3, 15, 914, DateTimeKind.Utc).AddTicks(3317), "$2a$11$D.O7NhlWaYvYs0QDMN9EXOKMSMCQqpnzDKecwyqsSzCyqJjK/Qajq" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 7, 27, 16, 45, 36, 175, DateTimeKind.Utc).AddTicks(9405), "$2a$11$cDlWe.f0eMLmTWTzswKnN.om7MVqhOWRAdW7anVn86ozcW327z8XG" });
        }
    }
}
