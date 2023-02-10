using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthcareMonitoring.Server.Migrations
{
    public partial class newHealthdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Prescriptions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Diagnoses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppdateTime",
                table: "Appointments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 13, 3, 13, 933, DateTimeKind.Local).AddTicks(6787), new DateTime(2023, 2, 9, 13, 3, 13, 933, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "9716467a-26c2-4177-9d5d-5c27ea4d08b9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "1fa2db09-3906-4b11-96fa-48df148ec614");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28dda56e-b2a1-43c7-b9f1-f089b063ac9b", "AQAAAAEAACcQAAAAEDfju0TzI/vehati5fcG7ayV7JdMqasztEZ8TbeTuetzE9VUDB2l7h3+kkeFT15Xyg==", "062b52d0-be4e-4449-b2c6-b890320c058c" });

            migrationBuilder.UpdateData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 13, 3, 13, 934, DateTimeKind.Local).AddTicks(3588), new DateTime(2023, 2, 9, 13, 3, 13, 934, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 13, 3, 13, 934, DateTimeKind.Local).AddTicks(9713), new DateTime(2023, 2, 9, 13, 3, 13, 934, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 13, 3, 13, 935, DateTimeKind.Local).AddTicks(7267), new DateTime(2023, 2, 9, 13, 3, 13, 935, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "PrescMeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 13, 3, 13, 936, DateTimeKind.Local).AddTicks(2508), new DateTime(2023, 2, 9, 13, 3, 13, 936, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 13, 3, 13, 936, DateTimeKind.Local).AddTicks(7366), new DateTime(2023, 2, 9, 13, 3, 13, 936, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 13, 3, 13, 929, DateTimeKind.Local).AddTicks(4853), new DateTime(2023, 2, 9, 13, 3, 13, 930, DateTimeKind.Local).AddTicks(9033) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Prescriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Diagnoses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AppdateTime",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 8, 26, 244, DateTimeKind.Local).AddTicks(1751), new DateTime(2023, 2, 7, 23, 8, 26, 244, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "1c883599-978d-4cb3-8f9a-3e589784ad11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "4a0fe248-cec2-4757-b6d1-b872be1d7299");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c39fe672-d6e5-423c-8db9-f3f3c16001b9", "AQAAAAEAACcQAAAAEG0YcnlA5qx5oqPl2XW8dDutKEK7GCXRC4MilVyeSBaDkRwMbA8O/iH7p9QDjDMImw==", "007b1a3a-125a-48cb-9314-d338cd1c4c4b" });

            migrationBuilder.UpdateData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 8, 26, 244, DateTimeKind.Local).AddTicks(6390), new DateTime(2023, 2, 7, 23, 8, 26, 244, DateTimeKind.Local).AddTicks(6399) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 8, 26, 245, DateTimeKind.Local).AddTicks(405), new DateTime(2023, 2, 7, 23, 8, 26, 245, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 8, 26, 245, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 2, 7, 23, 8, 26, 245, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "PrescMeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 8, 26, 245, DateTimeKind.Local).AddTicks(9108), new DateTime(2023, 2, 7, 23, 8, 26, 245, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 8, 26, 246, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 2, 7, 23, 8, 26, 246, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 7, 23, 8, 26, 241, DateTimeKind.Local).AddTicks(4848), new DateTime(2023, 2, 7, 23, 8, 26, 242, DateTimeKind.Local).AddTicks(3279) });
        }
    }
}
