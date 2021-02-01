using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "EntityId",
                keyValue: 2L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EntityId", "Name", "SelectedStoreEntityId" },
                values: new object[] { 1L, "UserA", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "EntityId", "Name", "SelectedStoreEntityId" },
                values: new object[] { 2L, "UserB", null });
        }
    }
}
