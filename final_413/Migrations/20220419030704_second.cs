using Microsoft.EntityFrameworkCore.Migrations;

namespace final_413.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "Quote_body", "Subject" },
                values: new object[] { 1, "Will Ferrell", null, null, "Before you marry a person, you should first make them use a computer with slow Internet to see who they really are.", null });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "Quote_body", "Subject" },
                values: new object[] { 2, "Will Durant", null, "1926", "We are what we repeatedly do. Excellence, then, is not an act, but a habit.", "Philosophy" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "Quote_body", "Subject" },
                values: new object[] { 3, "Harvey Specter", null, "2015", "It’s not bragging if it’s true.", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotes",
                keyColumn: "QuoteId",
                keyValue: 3);
        }
    }
}
