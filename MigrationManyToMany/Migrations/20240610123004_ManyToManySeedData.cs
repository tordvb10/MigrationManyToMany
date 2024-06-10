using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MigrationManyToMany.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Children",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Child 1" },
                    { 2, "Child 2" }
                });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Parent 1" },
                    { 2, "Parent 2" }
                });

            migrationBuilder.InsertData(
                table: "ParentsChildren",
                columns: new[] { "ChildId", "ParentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentsChildren",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ParentsChildren",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ParentsChildren",
                keyColumns: new[] { "ChildId", "ParentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Children",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Children",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
