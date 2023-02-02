using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthcareMonitoring.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "dosage",
                table: "PrescMeds",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "MedName",
                table: "Medicines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "b9fa1236-3a13-44c9-933e-2adc4fb0aa0f", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "38e22786-39b1-4ed9-a4b2-a12e44bcfc23", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ac56cec2-daea-4fe4-83c1-cf3a8b43b6d7", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEKzC72/EpdumcGk6BJU71BPzihkcvDVQSYucXY7GuG8LVvUWmR2PMxbIM/CCLIaXBg==", null, false, "c1a959ef-5d0a-449b-9e91-2aad5f10a128", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "PrescriptionId", "UpdatedBy", "dateTime" },
                values: new object[] { 1, 0, "System", new DateTime(2023, 1, 20, 10, 44, 20, 170, DateTimeKind.Local).AddTicks(9547), new DateTime(2023, 1, 20, 10, 44, 20, 170, DateTimeKind.Local).AddTicks(9553), "Back of throat is inflamed ", 0, "System", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ExpiryDate", "MedName", "Quantity", "UpdatedBy" },
                values: new object[] { 1, "System", new DateTime(2023, 1, 20, 10, 44, 20, 171, DateTimeKind.Local).AddTicks(2182), new DateTime(2023, 1, 20, 10, 44, 20, 171, DateTimeKind.Local).AddTicks(2188), "Antibiotic for bacterial infection", new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azithromycin", 200, "System" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "ContactNo", "CreatedBy", "DOB", "DateCreated", "DateUpdated", "Email", "Gender", "NRIC", "PatientName", "UpdatedBy" },
                values: new object[] { 1, "Blk 123 Paterville Ave 3 ", 123456789, "System", -1971, new DateTime(2023, 1, 20, 10, 44, 20, 171, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 1, 20, 10, 44, 20, 171, DateTimeKind.Local).AddTicks(5204), "Paterson@mail.com", "Male", "S1234567A", "Paterson", "System" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "UpdatedBy", "dateTime" },
                values: new object[] { 1, "System", new DateTime(2023, 1, 20, 10, 44, 20, 172, DateTimeKind.Local).AddTicks(22), new DateTime(2023, 1, 20, 10, 44, 20, 172, DateTimeKind.Local).AddTicks(27), "Drink Warm water and take the medicine for 5 days ", "System", new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "ContactNo", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "StaffName", "UpdatedBy" },
                values: new object[] { 1, "Blk 40 upper changi road", 98765678, "System", new DateTime(2023, 1, 20, 10, 44, 20, 168, DateTimeKind.Local).AddTicks(7028), new DateTime(2023, 1, 20, 10, 44, 20, 169, DateTimeKind.Local).AddTicks(4571), "lucy@gmail.com", "Female", "Lucy", "System" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppdateTime", "CreatedBy", "DateCreated", "DateUpdated", "Description", "PatientId", "StaffId", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2023, 1, 20, 10, 44, 20, 170, DateTimeKind.Local).AddTicks(7031), new DateTime(2023, 1, 20, 10, 44, 20, 170, DateTimeKind.Local).AddTicks(7042), "Sore throat ", 1, 1, "System" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "PrescMeds",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MedQty", "MedicineID", "PrescriptionID", "UpdatedBy", "dosage" },
                values: new object[] { 1, "System", new DateTime(2023, 1, 20, 10, 44, 20, 171, DateTimeKind.Local).AddTicks(7804), new DateTime(2023, 1, 20, 10, 44, 20, 171, DateTimeKind.Local).AddTicks(7809), 10, 1, 1, "System", "2 per day, after meal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PrescMeds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "MedName",
                table: "Medicines");

            migrationBuilder.AlterColumn<int>(
                name: "dosage",
                table: "PrescMeds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
