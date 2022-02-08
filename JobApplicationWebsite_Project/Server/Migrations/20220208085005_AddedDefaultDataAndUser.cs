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
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(6045), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "IndividSkills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(6057), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(6058) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "JobApplications",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(365), new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7184), new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7200), new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7204), new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.InsertData(
                table: "JobPosting",
                columns: new[] { "Id", "Benefits", "CreatedBy", "DateCreated", "DateUpdated", "NumberOfMonths", "NumberOfYears", "Position", "Responsiblity", "Salary", "UpdatedBy" },
                values: new object[,]
                {
                    { 5, "Health insurance.", null, new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7211), new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7210), 0, 3, "Accounts​/Senior Accounts Executive", "prepare the statement of accounts, balance sheet, reconciliations, preparing and posting of month end journals, processing payments and working closely with both internal and external stakeholders on accounting, reconciliation and treasury related matters.", 3500, null },
                    { 4, "Paid time off", "System", new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7207), new DateTime(2022, 2, 8, 16, 50, 4, 569, DateTimeKind.Local).AddTicks(7208), 4, 2, "Sales & Marketing Executive", "Sales pitching, create awareness for prospect vie all possible avenue, Analysing of vehicle trends from all avenues, but not limited to, SGCM, personal social circle,Price monitoring/comparison from competitors and/or owners;", 6000, "System" }
                });

            migrationBuilder.UpdateData(
                table: "Resume",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "https://resumegenius.com/wp-content/uploads/2019/07/Hostess-Resume-Sample-Template.png ");

            migrationBuilder.UpdateData(
                table: "Resume",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "https://196034-584727-raikfcquaxqncofqfm.stackpathdns.com/wp-content/uploads/2018/01/Electrician-Resume-723x1024.jpg");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(54), new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "JobPostingID", "Rating", "ReviewComment", "UpdatedBy", "UserNameId", "User_Name" },
                values: new object[,]
                {
                    { 4, "System", new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7224), 2, 4, "Company tries to be inclusive and they provide training to ensure that employees are inclusive as they go about their work. The work can be challenging, and depending on your department, employees get lots of support. ", "System", null, "Yew Yong Chang" },
                    { 5, "System", new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7225), new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7226), 2, 2, "Since being remote the communication is horrible! If your supervisor doesn’t know, you will be lost! The other supervisors take forever to respond because they have their own team to help. Also the vibe, unless you are a TOP agent. They do NOT care about you.", "System", null, "Yeo Chen Si" },
                    { 3, "System", new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7221), new DateTime(2022, 2, 8, 16, 50, 4, 567, DateTimeKind.Local).AddTicks(7222), 2, 4, "Management tries to be inclusive and they provide training to ensure that employees are inclusive as they go about their work. The work can be challenging, and depending on your department, employees get lots of support. ", "System", null, "Yew Yong Chang" }
                });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 570, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 2, 8, 16, 50, 4, 570, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "SkillSets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 570, DateTimeKind.Local).AddTicks(1745), new DateTime(2022, 2, 8, 16, 50, 4, 570, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2775), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2785), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "company",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2788), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.InsertData(
                table: "company",
                columns: new[] { "Id", "CompanyName", "CreatedBy", "DateCreated", "DateUpdated", "Description", "HRStaffID", "JobPostingId", "PostingID", "UpdatedBy" },
                values: new object[,]
                {
                    { 6, "Daiso", "System", new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2795), "Daiso Industries Co., Ltd. is a large franchise of 100-yen shops founded in Japan. The headquarters are in Higashihiroshima, Hiroshima Prefecture. Daiso has a range of over 100,000 products, of which over 40 percent are imported goods, many of them from China, South Korea, and Japan.", 6, null, 6, "System" },
                    { 5, "Spotify", "System", new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2792), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2793), "Spotify is a Swedish audio streaming and media services provider founded on 23 April 2006 by Daniel Ek and Martin Lorentzon. It is one of the largest music streaming service providers with over 406 million monthly active users, including 180 million paying subscribers, as of December 2021", 5, null, 5, "System" },
                    { 4, "Popular Holdings", "System", new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 2, 8, 16, 50, 4, 568, DateTimeKind.Local).AddTicks(2791), "Popular Holdings Limited, more commonly known as just Popular or colloquially as the Popular Bookstore, is a Singaporean multinational bookstore chain. Aside from Singapore, it also has subsidiaries in countries such as Canada, China, Malaysia and the United Kingdom.", 4, null, 4, "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPosting",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "company",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "company",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "company",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Resume",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Resume",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

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
    }
}
