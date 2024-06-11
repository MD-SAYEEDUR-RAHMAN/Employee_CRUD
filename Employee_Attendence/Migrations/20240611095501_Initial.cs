using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Employee_Attendence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyProperty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyProperty", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MyProperty",
                columns: new[] { "Id", "Designation", "Name" },
                values: new object[,]
                {
                    { 1, "Senior Frontend Developer", "Md.Sharafat Ayon" },
                    { 2, "Product Acceptance Engineer", "Mejbaur Bahar Fagun" },
                    { 3, "Business Analyst", "Ifrat Jahan Chowdhury" },
                    { 4, ".NET (Intern)", "Md Sayeedur Rahman" },
                    { 5, ".NET(Intern)", "Raisa Rokib" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyProperty");
        }
    }
}
