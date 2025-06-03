using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KiemTraMVC.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_nguyenchithanh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nguyenchithanh",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguyenchithanh", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nguyenchithanh");
        }
    }
}
