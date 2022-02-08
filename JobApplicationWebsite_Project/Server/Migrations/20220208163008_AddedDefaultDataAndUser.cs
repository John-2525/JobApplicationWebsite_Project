using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApplicationWebsite_Project.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(3582), new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(3588) });

            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(3591), new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(7282), new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(7292), new DateTime(2022, 2, 9, 0, 30, 7, 446, DateTimeKind.Local).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3437), new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3448), new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3451), new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3454), new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3458), new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 443, DateTimeKind.Local).AddTicks(9934), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2258), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2267), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2269), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2272), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(6542), new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(6551), new DateTime(2022, 2, 9, 0, 30, 7, 447, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9878), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9944), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9947), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9952), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9955), new DateTime(2022, 2, 9, 0, 30, 7, 445, DateTimeKind.Local).AddTicks(9956) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(8282), new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(8297), new DateTime(2022, 2, 9, 0, 29, 38, 789, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6140), new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6145), new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6148), new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6153), new DateTime(2022, 2, 9, 0, 29, 38, 790, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 786, DateTimeKind.Local).AddTicks(4495), new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8876), new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8886), new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8893), new DateTime(2022, 2, 9, 0, 29, 38, 787, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 791, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 2, 9, 0, 29, 38, 791, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 791, DateTimeKind.Local).AddTicks(344), new DateTime(2022, 2, 9, 0, 29, 38, 791, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7944), new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7964), new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7968), new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7971), new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7974), new DateTime(2022, 2, 9, 0, 29, 38, 788, DateTimeKind.Local).AddTicks(7976) });
        }
    }
}
