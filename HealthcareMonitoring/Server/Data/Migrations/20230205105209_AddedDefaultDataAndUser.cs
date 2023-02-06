using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthcareMonitoring.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diagnoses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnoses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NRIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrescMeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedQty = table.Column<int>(type: "int", nullable: false),
                    MedicineID = table.Column<int>(type: "int", nullable: false),
                    PrescriptionID = table.Column<int>(type: "int", nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescMeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescMeds_Medicines_MedicineID",
                        column: x => x.MedicineID,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiagnosisId = table.Column<int>(type: "int", nullable: true),
                    PrescMedId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Diagnoses_DiagnosisId",
                        column: x => x.DiagnosisId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_PrescMeds_PrescMedId",
                        column: x => x.PrescMedId,
                        principalTable: "PrescMeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "00558650-7d49-4fff-b965-33a2a2f88021", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "f98dc6a0-375b-44ae-a156-5825ddb3207a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d521f132-6c70-40c9-ab08-1d280b6daf93", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAECZmppW8Cfx8Pvf9sHLnv8KiFuhjaQ4OvQZnX4NYtAp0c6zgNC/GDd8DChBkYkb5MQ==", null, false, "2d02a8ff-0771-427e-b410-fce458fbe2ac", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "Id", "AppointmentId", "CreatedBy", "DateCreated", "DateTime", "DateUpdated", "Description", "PrescriptionId", "UpdatedBy" },
                values: new object[] { 2, 2, "System", new DateTime(2023, 2, 5, 18, 52, 8, 547, DateTimeKind.Local).AddTicks(4923), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 18, 52, 8, 547, DateTimeKind.Local).AddTicks(4928), "Inflamed throat with sores", 2, "System" });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ExpiryDate", "MedName", "Quantity", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2023, 2, 5, 18, 52, 8, 547, DateTimeKind.Local).AddTicks(7457), new DateTime(2023, 2, 5, 18, 52, 8, 547, DateTimeKind.Local).AddTicks(7462), "helps with body pain", new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "brufen", 200, "System" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "ContactNo", "CreatedBy", "DOB", "DateCreated", "DateUpdated", "Email", "Gender", "NRIC", "PatientName", "UpdatedBy" },
                values: new object[] { 2, "Blk 123 Paterville Ave 3 ", 123456789, "System", -1971, new DateTime(2023, 2, 5, 18, 52, 8, 548, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 2, 5, 18, 52, 8, 548, DateTimeKind.Local).AddTicks(347), "Paterson@mail.com", "Male", "S1234567A", "Paterson", "System" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateTime", "DateUpdated", "Description", "DiagnosisId", "PrescMedId", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2023, 2, 5, 18, 52, 8, 548, DateTimeKind.Local).AddTicks(4579), new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 5, 18, 52, 8, 548, DateTimeKind.Local).AddTicks(4582), "Drink Warm water and take the medicine for 5 days ", null, null, "System" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "ContactNo", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "StaffName", "UpdatedBy" },
                values: new object[] { 2, "Blk 98 Tampines Ave 3 ", 99456789, "System", new DateTime(2023, 2, 5, 18, 52, 8, 545, DateTimeKind.Local).AddTicks(3217), new DateTime(2023, 2, 5, 18, 52, 8, 545, DateTimeKind.Local).AddTicks(9557), "Peter@mail.com", "Male", "Peter", "System" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "AppdateTime", "CreatedBy", "DateCreated", "DateUpdated", "Description", "DiagnosisId", "PatientId", "StaffId", "UpdatedBy" },
                values: new object[] { 2, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "System", new DateTime(2023, 2, 5, 18, 52, 8, 547, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 2, 5, 18, 52, 8, 547, DateTimeKind.Local).AddTicks(2065), "Sore throat", null, 2, 2, "System" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "PrescMeds",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Dosage", "MedQty", "MedicineID", "PrescriptionID", "UpdatedBy" },
                values: new object[] { 2, "System", new DateTime(2023, 2, 5, 18, 52, 8, 548, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 2, 5, 18, 52, 8, 548, DateTimeKind.Local).AddTicks(2578), "Take 2 a day after meals.", 6, 2, 2, "System" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DiagnosisId",
                table: "Appointments",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_StaffId",
                table: "Appointments",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescMeds_MedicineID",
                table: "PrescMeds",
                column: "MedicineID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DiagnosisId",
                table: "Prescriptions",
                column: "DiagnosisId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PrescMedId",
                table: "Prescriptions",
                column: "PrescMedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Diagnoses");

            migrationBuilder.DropTable(
                name: "PrescMeds");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
