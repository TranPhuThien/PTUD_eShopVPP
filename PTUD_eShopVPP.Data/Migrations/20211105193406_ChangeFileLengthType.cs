using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PTUD_eShopVPP.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 6, 2, 34, 5, 911, DateTimeKind.Local).AddTicks(7175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 6, 1, 16, 34, 272, DateTimeKind.Local).AddTicks(8993));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 6, 1, 16, 34, 272, DateTimeKind.Local).AddTicks(8993),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 6, 2, 34, 5, 911, DateTimeKind.Local).AddTicks(7175));
        }
    }
}
