using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactServiceApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialContactTableSetUp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    mobile_number = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "varchar(50)", nullable: false),
                    location = table.Column<string>(type: "varchar(50)", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.mobile_number);
                });

            migrationBuilder.InsertData(
                table: "contacts",
                columns: new[] { "mobile_number", "email", "location", "name" },
                values: new object[] { 9090909090L, "anil@gmail.com", "Bangalore", "Anil" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");
        }
    }
}
