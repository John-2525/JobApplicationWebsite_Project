using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApplicationWebsite_Project.Server.Migrations
{
    public partial class AddDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(2966), new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(2981), new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(8352), new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(8363) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(8368), new DateTime(2022, 2, 5, 18, 20, 38, 498, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(5383), new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(5394) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(5404), new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 495, DateTimeKind.Local).AddTicks(5816), new DateTime(2022, 2, 5, 18, 20, 38, 496, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(712), new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(9953), new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 2, 5, 18, 20, 38, 499, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(7707), new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(7723), new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(7727), new DateTime(2022, 2, 5, 18, 20, 38, 497, DateTimeKind.Local).AddTicks(7728) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(251), new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(265), new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(5621), new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(5635), new DateTime(2022, 2, 5, 18, 20, 0, 27, DateTimeKind.Local).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(2603), new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(2617), new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(2619) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(2622), new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 24, DateTimeKind.Local).AddTicks(3282), new DateTime(2022, 2, 5, 18, 20, 0, 25, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 25, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 2, 5, 18, 20, 0, 25, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(6873), new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(6887), new DateTime(2022, 2, 5, 18, 20, 0, 28, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 26, DateTimeKind.Local).AddTicks(5326), new DateTime(2022, 2, 5, 18, 20, 0, 26, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 26, DateTimeKind.Local).AddTicks(5341), new DateTime(2022, 2, 5, 18, 20, 0, 26, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 5, 18, 20, 0, 26, DateTimeKind.Local).AddTicks(5345), new DateTime(2022, 2, 5, 18, 20, 0, 26, DateTimeKind.Local).AddTicks(5346) });
        }
    }
}
