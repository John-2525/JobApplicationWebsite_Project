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
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(388), new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(397), new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(4849), new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(4860), new DateTime(2022, 2, 8, 17, 10, 22, 981, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3155), new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3170), new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3176), new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3180), new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 978, DateTimeKind.Local).AddTicks(7874), new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9863), new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9871), new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9874), new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9877), new DateTime(2022, 2, 8, 17, 10, 22, 979, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(7559), new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(7569), new DateTime(2022, 2, 8, 17, 10, 22, 982, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6821), new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6834), new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6837), new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6838) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6839), new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6842), new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6844), new DateTime(2022, 2, 8, 17, 10, 22, 980, DateTimeKind.Local).AddTicks(6845) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4512), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4519) });

            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4523), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4524) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9256), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6288), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6303), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 17, DateTimeKind.Local).AddTicks(547), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3205), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3213), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3213) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3216), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(651), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(663), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(666), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(669), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(672), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(675), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(676) });
        }
    }
}
