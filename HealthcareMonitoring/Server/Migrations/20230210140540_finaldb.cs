using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthcareMonitoring.Server.Migrations
{
    public partial class finaldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 22, 5, 39, 818, DateTimeKind.Local).AddTicks(8345), new DateTime(2023, 2, 10, 22, 5, 39, 818, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "d56133dd-4598-45a1-9c18-d55758072e55");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "bfd23685-1edb-45de-b156-a2fc3525de4e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc699d3b-2b8e-43a8-bc7c-ed9ab514a319", "AQAAAAEAACcQAAAAEDwlIjjJNut+irS3sAWkVooNgYi/8Y23XutShnKaAtiLDTuMBsrC0PsVaUK0kL3aIw==", "68c34880-a31a-4eba-815d-a5a9a2796b3f" });

            migrationBuilder.UpdateData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(925), new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(3363), new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(5989), new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "PrescMeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 2, 10, 22, 5, 39, 819, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 22, 5, 39, 820, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 2, 10, 22, 5, 39, 820, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 22, 5, 39, 817, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 2, 10, 22, 5, 39, 817, DateTimeKind.Local).AddTicks(8780) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 16, 3, 20, 860, DateTimeKind.Local).AddTicks(7549), new DateTime(2023, 2, 10, 16, 3, 20, 860, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "9a6a8aee-d704-4115-ad77-ac6761f05583");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "90a3ea58-0262-40ed-affe-1cfce303ab23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4087043-42c0-4069-87ff-1dcb6ad771c6", "AQAAAAEAACcQAAAAEIFnQMHiakq42ZXNMWMD5CBOKh2poKUanGzNQ/KZ4i+Kr/1xuZ3SWELmVd3MGNP5cQ==", "f5b3da31-dff5-4f5f-b593-f92583b273a3" });

            migrationBuilder.UpdateData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(6050), new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "PrescMeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(8472), new DateTime(2023, 2, 10, 16, 3, 20, 861, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 16, 3, 20, 862, DateTimeKind.Local).AddTicks(530), new DateTime(2023, 2, 10, 16, 3, 20, 862, DateTimeKind.Local).AddTicks(534) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 10, 16, 3, 20, 858, DateTimeKind.Local).AddTicks(8804), new DateTime(2023, 2, 10, 16, 3, 20, 859, DateTimeKind.Local).AddTicks(6277) });
        }
    }
}
