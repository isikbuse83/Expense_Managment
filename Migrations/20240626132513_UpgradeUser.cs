using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_Management.Migrations
{
    /// <inheritdoc />
    public partial class UpgradeUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category_Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Expence",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Expense_Total",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Usersurname",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Expense_report",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Expense_category",
                table: "Users",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Usersurname");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "Expense_report");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "Expense_category");

            migrationBuilder.AddColumn<string>(
                name: "Category_Id",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Expence",
                table: "Users",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Expense_Total",
                table: "Users",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
