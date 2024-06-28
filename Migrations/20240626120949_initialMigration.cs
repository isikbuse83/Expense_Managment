using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_Managment.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usersurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expense_category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expence = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Category_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expense_report = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expense_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
