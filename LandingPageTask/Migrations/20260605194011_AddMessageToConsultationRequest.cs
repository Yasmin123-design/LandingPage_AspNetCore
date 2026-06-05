using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LandingPageTask.Migrations
{
    /// <inheritdoc />
    public partial class AddMessageToConsultationRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "ConsultationRequests",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "ConsultationRequests");
        }
    }
}
