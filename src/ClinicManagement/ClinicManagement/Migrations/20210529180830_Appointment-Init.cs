using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicManagement.Migrations
{
    public partial class AppointmentInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.CreateTable(
                name: "DoctorTable",
                columns: table => new
                {
                    DoctorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecializationRequired = table.Column<int>(type: "int", nullable: false),
                    Experiance = table.Column<int>(type: "int", nullable: false),
                    DocEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorTable", x => x.DoctorID);
                });

            migrationBuilder.CreateTable(
                name: "PatientsTable",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientPhone = table.Column<long>(type: "bigint", nullable: false),
                    PatEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsTable", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
               name: "AppointmentTable",
               columns: table => new
               {
                   AppointmentId = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   PatientId = table.Column<int>(type: "int", nullable: false),
                   SpecializationRequired = table.Column<int>(type: "int", nullable: false),
                   DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                   ToTime = table.Column<DateTime>(type: "datetime2", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_AppointmentTable", x => x.AppointmentId);
                   table.ForeignKey(
                      name: "FK_AppointmentTable_PatientsTable_PatientId",
                      column: x => x.PatientId,
                      principalTable: "PatientsTable",
                      principalColumn: "PatientId",
                      onDelete: ReferentialAction.Restrict);
               });




            migrationBuilder.CreateTable(
                name: "SignInTable",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RememberMe = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignInTable", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "SignUpTable",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    StaffEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignUpTable", x => x.Username);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentTable");

            migrationBuilder.DropTable(
                name: "DoctorTable");

            migrationBuilder.DropTable(
                name: "PatientsTable");

            migrationBuilder.DropTable(
                name: "SignInTable");

            migrationBuilder.DropTable(
                name: "SignUpTable");
        }
    }
}
