using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizDataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Score = table.Column<int>(nullable: false),
                    TimeTaken = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QnInWords = table.Column<string>(maxLength: 250, nullable: true),
                    QnImage = table.Column<string>(maxLength: 50, nullable: true),
                    Option1 = table.Column<string>(maxLength: 50, nullable: true),
                    Option2 = table.Column<string>(maxLength: 50, nullable: true),
                    Option3 = table.Column<string>(maxLength: 50, nullable: true),
                    Option4 = table.Column<string>(maxLength: 50, nullable: true),
                    Answer = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QnID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
