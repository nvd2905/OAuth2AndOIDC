using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dar.IDP.Migrations
{
    /// <inheritdoc />
    public partial class addUserSecretT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("53204434-9c83-451e-9736-de90cf8f1add"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("62e1ef56-9675-4fa4-a677-1853362611cd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6a9ccdf3-c860-4f43-a74b-61be75a60314"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("731a448d-446f-46c4-8a1b-8c70c42c305c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8c4b19e4-d015-4bd6-a7b6-f1c9c22ab3a1"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8e47eb5e-fd01-45a2-acb1-be84a392787d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("affdf942-a82f-4359-b533-93e4e1daae2d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("cd8b79ea-a04c-45fb-b7cf-7ada7d7279e6"));

            migrationBuilder.CreateTable(
                name: "UserSecret",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Secret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSecret", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSecret_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("251e7f9b-ef98-448a-b79a-662b31982c6d"), "5f07ebd9-227f-433b-8772-42817aec3e59", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("255af6d1-fd3c-4894-8586-bd6201f9b383"), "e501f303-5225-4e74-ad93-7cbcae4252c8", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("5818efe3-c1e3-47d3-b402-7868a0452786"), "37b55198-d805-4e24-a3a1-33431507f52a", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("62d43182-4585-4952-9e4f-6134b2bf1267"), "034ebf3a-80b7-4c05-b8f2-3fbd02ef3060", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("674e8f3b-6a01-40ed-87f0-5dbaf7166345"), "0f6843a3-443d-4386-a12f-6fa1ae933dd4", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("6bc2ce86-bf0b-4273-9db3-1082ae87a67e"), "4a3a1859-704e-4cc3-90e4-924f56feca19", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("9ddcc078-86b5-4f27-adb7-35735086b2cf"), "55be89a4-0f8a-4750-8c35-b278d0544982", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("f3dc84dc-d981-46db-a79b-15a1cb716632"), "543d4114-1462-47ac-a7d2-ac1f1c8b023d", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "3d8f6997-70f7-4239-99d8-02aac578b2fa");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "d4ddf59f-4b19-451d-9284-eecf690004fb");

            migrationBuilder.CreateIndex(
                name: "IX_UserSecret_UserId",
                table: "UserSecret",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserSecret");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("251e7f9b-ef98-448a-b79a-662b31982c6d"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("255af6d1-fd3c-4894-8586-bd6201f9b383"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5818efe3-c1e3-47d3-b402-7868a0452786"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("62d43182-4585-4952-9e4f-6134b2bf1267"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("674e8f3b-6a01-40ed-87f0-5dbaf7166345"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6bc2ce86-bf0b-4273-9db3-1082ae87a67e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9ddcc078-86b5-4f27-adb7-35735086b2cf"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f3dc84dc-d981-46db-a79b-15a1cb716632"));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("53204434-9c83-451e-9736-de90cf8f1add"), "52dd5e56-ffa2-41aa-b466-eac15eae1ac2", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("62e1ef56-9675-4fa4-a677-1853362611cd"), "8134529b-e85a-4f69-a69e-34d26a56d116", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("6a9ccdf3-c860-4f43-a74b-61be75a60314"), "f17c93ef-4663-49ac-aef9-e5303ec90fb6", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("731a448d-446f-46c4-8a1b-8c70c42c305c"), "25f53b83-939b-4750-8c27-dd4cfeffa5f4", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("8c4b19e4-d015-4bd6-a7b6-f1c9c22ab3a1"), "750eb36b-4a78-4e38-8cb4-898522473319", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("8e47eb5e-fd01-45a2-acb1-be84a392787d"), "7ce88f33-a3d4-407c-a50b-74de1f7924f7", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("affdf942-a82f-4359-b533-93e4e1daae2d"), "8952e7dc-df80-4818-8a24-c4665503416c", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("cd8b79ea-a04c-45fb-b7cf-7ada7d7279e6"), "0c70bee1-8e71-4932-a425-d1bae277585a", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "cb0dcd92-6573-4b86-823d-904308f9bee0");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "58216c19-6938-473c-a9cf-f8eb514359e9");
        }
    }
}
