using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_Management.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Report_Id = table.Column<int>(type: "int", nullable: false),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserExpenses_Expense_Category_Id",
                table: "UserExpenses",
                column: "Expense_Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserExpenses_Categories_Expense_Category_Id",
                table: "UserExpenses",
                column: "Expense_Category_Id",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserExpenses_Categories_Expense_Category_Id",
                table: "UserExpenses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_UserExpenses_Expense_Category_Id",
                table: "UserExpenses");
        }
    }
}
