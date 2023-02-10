using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthcareMonitoring.Server.Migrations
{
    public partial class newhealthdb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Diagnoses_DiagnosisId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_PrescMeds_PrescMedId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_DiagnosisId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_PrescMedId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DiagnosisId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "PrescMedId",
                table: "Prescriptions");

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

            migrationBuilder.CreateIndex(
                name: "IX_PrescMeds_PrescriptionID",
                table: "PrescMeds",
                column: "PrescriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_PrescriptionId",
                table: "Diagnoses",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_Prescriptions_PrescriptionId",
                table: "Diagnoses",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescMeds_Prescriptions_PrescriptionID",
                table: "PrescMeds",
                column: "PrescriptionID",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_Prescriptions_PrescriptionId",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescMeds_Prescriptions_PrescriptionID",
                table: "PrescMeds");

            migrationBuilder.DropIndex(
                name: "IX_PrescMeds_PrescriptionID",
                table: "PrescMeds");

            migrationBuilder.DropIndex(
                name: "IX_Diagnoses_PrescriptionId",
                table: "Diagnoses");

            migrationBuilder.AddColumn<int>(
                name: "DiagnosisId",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrescMedId",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 11, 58, 210, DateTimeKind.Local).AddTicks(7123), new DateTime(2023, 2, 9, 17, 11, 58, 210, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "3419defd-b8d2-4594-9a78-09b6ca648433");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "e3c3998a-b89a-486b-8169-e5f65820be91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02146e14-a01b-4568-902c-1d7c2ff0d044", "AQAAAAEAACcQAAAAEN6SRAS7WY4K4bOohQpNQYfnVwemDoUzPmZW0hHvF+ZYpynoPsftL7aXoY377sFxRA==", "c45237fa-1ab0-4047-9990-dacdd76b7aa5" });

            migrationBuilder.UpdateData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 11, 58, 211, DateTimeKind.Local).AddTicks(1108), new DateTime(2023, 2, 9, 17, 11, 58, 211, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 11, 58, 211, DateTimeKind.Local).AddTicks(4684), new DateTime(2023, 2, 9, 17, 11, 58, 211, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 11, 58, 211, DateTimeKind.Local).AddTicks(8550), new DateTime(2023, 2, 9, 17, 11, 58, 211, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "PrescMeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 11, 58, 212, DateTimeKind.Local).AddTicks(1865), new DateTime(2023, 2, 9, 17, 11, 58, 212, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 11, 58, 212, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 2, 9, 17, 11, 58, 212, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 2, 9, 17, 11, 58, 208, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 2, 9, 17, 11, 58, 209, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DiagnosisId",
                table: "Prescriptions",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PrescMedId",
                table: "Prescriptions",
                column: "PrescMedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Diagnoses_DiagnosisId",
                table: "Prescriptions",
                column: "DiagnosisId",
                principalTable: "Diagnoses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_PrescMeds_PrescMedId",
                table: "Prescriptions",
                column: "PrescMedId",
                principalTable: "PrescMeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
