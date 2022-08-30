using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class IdentityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "376a9c5d-a8b8-4bbd-af85-3e779e6a1a7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb39cdd5-c4f1-4527-8669-7558923bd1f2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8ab2be9-0e0a-4b34-831e-e6372587d467", "f2bab04f-a3cf-4987-b058-339efae7e81b", "Member", "MEMBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b3bfc77e-22a7-4db2-bf7e-1790b00ab284", "36fb944b-6d7a-456c-89c0-9d16ec62ad9d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8ab2be9-0e0a-4b34-831e-e6372587d467");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3bfc77e-22a7-4db2-bf7e-1790b00ab284");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb39cdd5-c4f1-4527-8669-7558923bd1f2", "7f1235be-0425-46d3-96bd-73b0316ca911", "Member", "MEMEBER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "376a9c5d-a8b8-4bbd-af85-3e779e6a1a7f", "a106460b-b04f-4ff9-b522-663e469c792c", "Admin", "ADMIN" });
        }
    }
}
