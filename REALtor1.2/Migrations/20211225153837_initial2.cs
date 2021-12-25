using Microsoft.EntityFrameworkCore.Migrations;

namespace REALtor1._2.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e70088-f003-4dd2-ae7f-b6fd6b8239d5",
                column: "ConcurrencyStamp",
                value: "74fc2736-37fd-48d8-9562-73c225f11184");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586347a0-0208-44e2-b3cc-86138a23a89e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85c817bf-70bf-4d0d-900e-4f671e58e40d", "AQAAAAEAACcQAAAAEKayveDnGgAPcWONG0DjbAxP+H3ba0t+MkdAlW3Q6yEPiVTp1SD3quJ/7P6bZbSIqg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e70088-f003-4dd2-ae7f-b6fd6b8239d5",
                column: "ConcurrencyStamp",
                value: "28426467-44c5-4216-bbbf-733c5abfcd05");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586347a0-0208-44e2-b3cc-86138a23a89e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "390d0f55-fa52-4d2e-a7e4-d992654f8abf", "AQAAAAEAACcQAAAAECZZp095WRggiwpeFFwv0zUxqcS7vS526Z01pNqQJX7VGhw1nSTGAMheuEyPi97t7g==" });
        }
    }
}
