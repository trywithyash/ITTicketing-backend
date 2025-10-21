using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITTicketing.Backend.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleCode" },
                values: new object[,]
                {
                    { 1, "EMPLOYEE" },
                    { 2, "IT_PERSON" },
                    { 3, "L1_MANAGER" },
                    { 4, "L2_HEAD" },
                    { 5, "COO" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Department", "Email", "FullName", "ManagerId", "Password", "RoleId", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 100, "Executive", "minan@abstractgroup.com", "Minan (CEO)", null, "HASHED_DEFAULT_PASSWORD", 5, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "minan.ceo" },
                    { 101, "Executive", "rashmi@abstractgroup.com", "Rashmi (COO)", 100, "HASHED_DEFAULT_PASSWORD", 5, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "rashmi.coo" },
                    { 201, "Operations", "anjali@abstractgroup.com", "Anjali (L2 Head)", 101, "HASHED_DEFAULT_PASSWORD", 4, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "anjali.l2" },
                    { 202, "Operations", "rohan@abstractgroup.com", "Rohan (L2 Head)", 101, "HASHED_DEFAULT_PASSWORD", 4, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "rohan.l2" },
                    { 301, "Operations", "deepak@abstractgroup.com", "Deepak (L1 Manager)", 201, "HASHED_DEFAULT_PASSWORD", 3, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "deepak.l1" },
                    { 302, "Finance", "kavita@abstractgroup.com", "Kavita (L1 Manager)", 201, "HASHED_DEFAULT_PASSWORD", 3, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "kavita.l1" },
                    { 303, "Marketing", "simran@abstractgroup.com", "Simran (L1 Manager)", 202, "HASHED_DEFAULT_PASSWORD", 3, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "simran.l1" },
                    { 401, "IT Support", "rahul@abstractgroup.com", "Rahul (IT Person)", 301, "HASHED_DEFAULT_PASSWORD", 2, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "rahul.it" },
                    { 402, "IT Support", "sneha@abstractgroup.com", "Sneha (IT Person)", 301, "HASHED_DEFAULT_PASSWORD", 2, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "sneha.it" },
                    { 403, "IT Support", "amit@abstractgroup.com", "Amit (IT Person)", 302, "HASHED_DEFAULT_PASSWORD", 2, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "amit.it" },
                    { 404, "IT Support", "vikas@abstractgroup.com", "Vikas (IT Person)", 303, "HASHED_DEFAULT_PASSWORD", 2, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "vikas.it" },
                    { 501, "Marketing", "tara@abstractgroup.com", "Tara (Employee)", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "tara.emp" },
                    { 502, "Marketing", "alex@abstractgroup.com", "Alex (Employee)", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "alex.emp" },
                    { 503, "HR", "radha@abstractgroup.com", "Radha (Employee)", 402, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "radha.emp" },
                    { 504, "Finance", "neha@abstractgroup.com", "Neha (Employee)", 403, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "neha.emp" },
                    { 505, "Sales", "priya@abstractgroup.com", "Priya (Employee)", 404, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "priya.emp" },
                    { 506, "Dept 2", "employee_506@abstractgroup.com", "Test Employee 506", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_506" },
                    { 507, "Dept 3", "employee_507@abstractgroup.com", "Test Employee 507", 402, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_507" },
                    { 508, "Dept 4", "employee_508@abstractgroup.com", "Test Employee 508", 403, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_508" },
                    { 509, "Dept 5", "employee_509@abstractgroup.com", "Test Employee 509", 404, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_509" },
                    { 510, "Dept 1", "employee_510@abstractgroup.com", "Test Employee 510", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_510" },
                    { 511, "Dept 2", "employee_511@abstractgroup.com", "Test Employee 511", 402, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_511" },
                    { 512, "Dept 3", "employee_512@abstractgroup.com", "Test Employee 512", 403, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_512" },
                    { 513, "Dept 4", "employee_513@abstractgroup.com", "Test Employee 513", 404, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_513" },
                    { 514, "Dept 5", "employee_514@abstractgroup.com", "Test Employee 514", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_514" },
                    { 515, "Dept 1", "employee_515@abstractgroup.com", "Test Employee 515", 402, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_515" },
                    { 516, "Dept 2", "employee_516@abstractgroup.com", "Test Employee 516", 403, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_516" },
                    { 517, "Dept 3", "employee_517@abstractgroup.com", "Test Employee 517", 404, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_517" },
                    { 518, "Dept 4", "employee_518@abstractgroup.com", "Test Employee 518", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_518" },
                    { 519, "Dept 5", "employee_519@abstractgroup.com", "Test Employee 519", 402, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_519" },
                    { 520, "Dept 1", "employee_520@abstractgroup.com", "Test Employee 520", 403, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_520" },
                    { 521, "Dept 2", "employee_521@abstractgroup.com", "Test Employee 521", 404, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_521" },
                    { 522, "Dept 3", "employee_522@abstractgroup.com", "Test Employee 522", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_522" },
                    { 523, "Dept 4", "employee_523@abstractgroup.com", "Test Employee 523", 402, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_523" },
                    { 524, "Dept 5", "employee_524@abstractgroup.com", "Test Employee 524", 403, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_524" },
                    { 525, "Dept 1", "employee_525@abstractgroup.com", "Test Employee 525", 404, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_525" },
                    { 526, "Dept 2", "employee_526@abstractgroup.com", "Test Employee 526", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_526" },
                    { 527, "Dept 3", "employee_527@abstractgroup.com", "Test Employee 527", 402, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_527" },
                    { 528, "Dept 4", "employee_528@abstractgroup.com", "Test Employee 528", 403, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_528" },
                    { 529, "Dept 5", "employee_529@abstractgroup.com", "Test Employee 529", 404, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_529" },
                    { 530, "Dept 1", "employee_530@abstractgroup.com", "Test Employee 530", 401, "HASHED_DEFAULT_PASSWORD", 1, new DateTime(2025, 10, 21, 10, 52, 30, 228, DateTimeKind.Utc).AddTicks(1446), "emp_test_530" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 5);
        }
    }
}
