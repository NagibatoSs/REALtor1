using Microsoft.EntityFrameworkCore.Migrations;

namespace REALtor1._2.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "hotWater",
                table: "House",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "gas",
                table: "House",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "electricity",
                table: "House",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "coldWater",
                table: "House",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "hotWater",
                table: "House",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "gas",
                table: "House",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "electricity",
                table: "House",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "coldWater",
                table: "House",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e70088-f003-4dd2-ae7f-b6fd6b8239d5",
                column: "ConcurrencyStamp",
                value: "f0a4fd8a-3843-4a7c-8046-19b2265f983b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586347a0-0208-44e2-b3cc-86138a23a89e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04ba51df-de6f-4ef5-ac9a-09bdd0034652", "AQAAAAEAACcQAAAAEP4Ul1xIAzMGrB6dYfdFdDIo514dBjwrCiJFUiwNzwe8/f1V1iZMDVfNaeLOqhcyyw==" });
        }
    }
}
