using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Migrations
{
    public partial class s5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("ec44e35d-6751-4b6b-a5c4-f147d2300b1d"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("3f213e00-43ce-488b-8e43-ff244a2009fb"), new Guid("e3e148af-0576-466e-b783-736c0f27f989"), new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("22e62dda-eec5-40c2-872d-f5c495025d7c"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("74175c1d-096c-4274-97ee-0ea5cc3a7117"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.InsertData(
                table: "Member",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Email", "GroupId", "LastLogin", "LoginName", "ModifiedBy", "ModifiedOn", "Name", "Password", "Picture" },
                values: new object[] { new Guid("8c7e1501-422e-47e1-8f81-bfb3d226653b"), null, new DateTime(2024, 8, 16, 13, 36, 46, 410, DateTimeKind.Local).AddTicks(214), "lethuonglong@gmail.com", new Guid("e3e148af-0576-466e-b783-736c0f27f989"), null, "lethuonglong", null, null, "Lê Thượng Long", "12345", "/img/users/wean.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authorized",
                keyColumn: "Id",
                keyValue: new Guid("3f213e00-43ce-488b-8e43-ff244a2009fb"));

            migrationBuilder.DeleteData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("8c7e1501-422e-47e1-8f81-bfb3d226653b"));

            migrationBuilder.InsertData(
                table: "Authorized",
                columns: new[] { "Id", "GroupId", "RoleId" },
                values: new object[] { new Guid("ec44e35d-6751-4b6b-a5c4-f147d2300b1d"), new Guid("e3e148af-0576-466e-b783-736c0f27f989"), new Guid("8cbc6a66-dce6-44c5-96c9-f8d700434016") });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("1e1ca786-81c5-4c4c-b3a7-2e79e1ce0894"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 34, 10, 491, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("22e62dda-eec5-40c2-872d-f5c495025d7c"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 34, 10, 491, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("2d6349ba-b2b6-49ce-8f9b-4531ec7372dd"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 34, 10, 491, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("3a70fb4a-b22c-469f-8f50-5e3047d5b599"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 34, 10, 491, DateTimeKind.Local).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("74175c1d-096c-4274-97ee-0ea5cc3a7117"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 34, 10, 491, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Member",
                keyColumn: "Id",
                keyValue: new Guid("e3d1cf68-a04c-4ff8-89d8-40266246c86e"),
                column: "CreatedOn",
                value: new DateTime(2024, 8, 16, 13, 34, 10, 491, DateTimeKind.Local).AddTicks(4866));
        }
    }
}
