using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class s2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("0c3dee6d-50f0-4065-ab16-249b8217ba46"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("e990cd85-5f78-4d38-9197-630b1078a0ec"), new Guid("e3e148af-0576-466e-b783-736c0f27f989"), new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("22e62dda-eec5-40c2-872d-f5c495025d7c"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("74175c1d-096c-4274-97ee-0ea5cc3a7117"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 2, 10, 34, 58, 918, DateTimeKind.Local).AddTicks(5142));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("e990cd85-5f78-4d38-9197-630b1078a0ec"));

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Order");

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("0c3dee6d-50f0-4065-ab16-249b8217ba46"), new Guid("e3e148af-0576-466e-b783-736c0f27f989"), new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 1, 19, 40, 4, 347, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("22e62dda-eec5-40c2-872d-f5c495025d7c"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 1, 19, 40, 4, 347, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 1, 19, 40, 4, 347, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 1, 19, 40, 4, 347, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("74175c1d-096c-4274-97ee-0ea5cc3a7117"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 1, 19, 40, 4, 347, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 1, 19, 40, 4, 347, DateTimeKind.Local).AddTicks(8280));
        }
    }
}
