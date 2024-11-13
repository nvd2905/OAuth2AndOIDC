using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dar.IDP.Migrations
{
    /// <inheritdoc />
    public partial class addAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("15ec32aa-c0d5-4120-867c-80fd17421969"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("27745f9a-3b6c-47a6-b38e-bc88bd3bc07f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("66eb9ddb-4d7d-4f0e-8641-7df75838868e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("790b6bbe-79cf-4aac-b12f-0b5bda509b2b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8523850a-8d8f-48ec-a72e-cdc7feaecec0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b4ddd4b1-52ef-4ab6-a726-1b25ab983754"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c58df06a-86cd-4ab8-b2fd-e51fb22d2a65"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("da8ca237-69a9-4fb1-922f-72dd460ba72b"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("0a039fc7-df44-445d-968c-e34cbe2892aa"), "a9d7c677-cb9e-4c16-908b-3bf112b8a714", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("5e28d362-0cba-4848-ac28-1480d75d3f34"), "58ae797b-b5b7-4633-8c5c-bcebec3ba2c1", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("7dbfacca-5529-4d5e-9e25-960742f8f551"), "8c50a966-68ed-4037-966a-ed353cb4d63f", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("8805f159-47c0-4bf4-94ac-513e17058d0c"), "4a6d7783-4365-4b9f-bf97-02a6575b9cac", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("8967f002-f0f6-4149-80fc-0c18be5d619b"), "3ca20dff-86de-4c98-aa09-bc8e461084a3", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("a62b6d3c-a123-479f-8cb7-45584e3cbceb"), "6b15d055-5e11-4e62-ac39-a39d80f2a8d8", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("a9cad449-7e4f-40cc-8259-3ac364fb9734"), "f059e530-3beb-48bb-a51b-059f0974d654", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("c2bc2aa5-04c5-4ca2-8aa4-cfe48ccc8032"), "ee19d1de-6b2f-4001-baa5-99de2dff2a0c", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "22aa7b05-ddb9-4eb1-a839-78ec5313fff8", "david@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "d3edd7de-005f-4c5e-8da9-c85ab3c137da", "emma@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0a039fc7-df44-445d-968c-e34cbe2892aa"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5e28d362-0cba-4848-ac28-1480d75d3f34"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7dbfacca-5529-4d5e-9e25-960742f8f551"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8805f159-47c0-4bf4-94ac-513e17058d0c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8967f002-f0f6-4149-80fc-0c18be5d619b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a62b6d3c-a123-479f-8cb7-45584e3cbceb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("a9cad449-7e4f-40cc-8259-3ac364fb9734"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c2bc2aa5-04c5-4ca2-8aa4-cfe48ccc8032"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("15ec32aa-c0d5-4120-867c-80fd17421969"), "b78445eb-5d6f-4607-a268-cf5fdbfd5941", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("27745f9a-3b6c-47a6-b38e-bc88bd3bc07f"), "11bfbbb6-f724-4c4a-a3da-82b2acecc6c4", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("66eb9ddb-4d7d-4f0e-8641-7df75838868e"), "27400b66-db85-4e22-88a1-a5d556ad2b28", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("790b6bbe-79cf-4aac-b12f-0b5bda509b2b"), "59125353-460e-4390-b87a-4fea92a7b761", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("8523850a-8d8f-48ec-a72e-cdc7feaecec0"), "5b961930-a670-452e-8e68-11158619f3ab", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("b4ddd4b1-52ef-4ab6-a726-1b25ab983754"), "13f6f145-db51-44b8-8e16-c3d80d909ac2", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("c58df06a-86cd-4ab8-b2fd-e51fb22d2a65"), "c60dfad0-98a0-49a4-b075-37668a474302", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("da8ca237-69a9-4fb1-922f-72dd460ba72b"), "0bdff1f3-f379-4aa3-8c4e-3223854c661e", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "06ce345e-bea0-4233-ba30-81919cf5593e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "a70cb06f-7284-4656-8adb-9003e5d4e545");
        }
    }
}
