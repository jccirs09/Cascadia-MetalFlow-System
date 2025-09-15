using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cascadia_MetalFlow_System.Migrations
{
    /// <inheritdoc />
    public partial class AddBranchToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyBranchId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyBranchId",
                table: "AspNetUsers",
                column: "CompanyBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CompanyBranches_CompanyBranchId",
                table: "AspNetUsers",
                column: "CompanyBranchId",
                principalTable: "CompanyBranches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CompanyBranches_CompanyBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CompanyBranchId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompanyBranchId",
                table: "AspNetUsers");
        }
    }
}
