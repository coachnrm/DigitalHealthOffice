using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoSimpleBlazorUserAndRoleManager.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPortalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Portal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueueId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortalType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrgentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PortalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPort1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPort2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPort3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndPort4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portal", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Portal");
        }
    }
}
