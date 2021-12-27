using Microsoft.EntityFrameworkCore.Migrations;

namespace REALtor1._2.Migrations
{
    public partial class Initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e70088-f003-4dd2-ae7f-b6fd6b8239d5",
                column: "ConcurrencyStamp",
                value: "afb230d4-bed5-42ce-acec-5c25dd0b85a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586347a0-0208-44e2-b3cc-86138a23a89e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf4cbcf5-b149-434a-81d6-5ce0b9554df6", "AQAAAAEAACcQAAAAEKteVr940bQDonemIKObZmHlysms1j7fluYKi9mf6jJw+FD9dUP8vMwSL4Z9qKfx+w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e70088-f003-4dd2-ae7f-b6fd6b8239d5",
                column: "ConcurrencyStamp",
                value: "3456368e-9453-49c6-b1c6-a39f5c766c79");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586347a0-0208-44e2-b3cc-86138a23a89e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9252065c-e841-40fc-8994-3e125e5d4611", "AQAAAAEAACcQAAAAEFsT2GBvkXfQc9pz8ajLHyki0fMET7lRAvWIsxHnEVbpkwY2viRFxVK6UH7oeQclAA==" });
        }
    }
}
