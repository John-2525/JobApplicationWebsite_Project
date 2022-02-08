using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobApplicationWebsite_Project.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "IndividSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearsofExperience = table.Column<int>(type: "int", nullable: false),
                    Mastery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPosting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfYears = table.Column<int>(type: "int", nullable: false),
                    NumberOfMonths = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Benefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsiblity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPosting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostingID = table.Column<int>(type: "int", nullable: true),
                    JobPostingId = table.Column<int>(type: "int", nullable: true),
                    HRStaffID = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_company_JobPosting_JobPostingId",
                        column: x => x.JobPostingId,
                        principalTable: "JobPosting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostingID = table.Column<int>(type: "int", nullable: false),
                    JobPostingId = table.Column<int>(type: "int", nullable: true),
                    IndividSkillsID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillSets_IndividSkills_IndividSkillsID",
                        column: x => x.IndividSkillsID,
                        principalTable: "IndividSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillSets_JobPosting_JobPostingId",
                        column: x => x.JobPostingId,
                        principalTable: "JobPosting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserResume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNameId = table.Column<int>(type: "int", nullable: true),
                    JobPostingID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplications_JobPosting_JobPostingID",
                        column: x => x.JobPostingID,
                        principalTable: "JobPosting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobApplications_User_UserNameId",
                        column: x => x.UserNameId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certificates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resume_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    User_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserNameId = table.Column<int>(type: "int", nullable: true),
                    JobPostingID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_JobPosting_JobPostingID",
                        column: x => x.JobPostingID,
                        principalTable: "JobPosting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_User_UserNameId",
                        column: x => x.UserNameId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "IndividSkills",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Mastery", "SkillName", "UpdatedBy", "YearsofExperience" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4512), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4519), "novice", "baking", "System", 3 },
                    { 2, "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4523), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(4524), "expert", "Fixing", "System", 10 }
                });

            migrationBuilder.InsertData(
                table: "JobPosting",
                columns: new[] { "Id", "Benefits", "CreatedBy", "DateCreated", "DateUpdated", "NumberOfMonths", "NumberOfYears", "Position", "Responsiblity", "Salary", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Health Insurance , Paid time off , Life inusrance", "System", new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6288), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6296), 3, 2, "Digital Media Production Assistant", "Assist with all social media department logistics such as platform scheduling, copywriting, content calendar reviews, and posting support.Assist with production of social content shoots  including being on - set for photo and video shoots supporting where necessary", 2500, "System" },
                    { 5, "Health insurance.", null, new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6309), 0, 3, "Accounts​/Senior Accounts Executive", "prepare the statement of accounts, balance sheet, reconciliations, preparing and posting of month end journals, processing payments and working closely with both internal and external stakeholders on accounting, reconciliation and treasury related matters.", 3500, null },
                    { 4, "Paid time off", "System", new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6307), 4, 2, "Sales & Marketing Executive", "Sales pitching, create awareness for prospect vie all possible avenue, Analysing of vehicle trends from all avenues, but not limited to, SGCM, personal social circle,Price monitoring/comparison from competitors and/or owners;", 6000, "System" },
                    { 3, "Paid time off", "System", new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6303), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6304), 0, 3, "Delivery Driver", "Loading up and counting of stocks before going out for delivery and counting balance of stocks when deliveries are done, place balance of stocks back intofactory's chillers at the end of the day. Main delivery route will be to NTUC and Giant outlets.", 2600, "System" },
                    { 2, "Mental Health Benfits , Flexible work arrangements", "System", new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(6301), 1, 2, "Office Administrator", "Independently run the office space on a day-to-day basis to ensure smooth operations,Attend to incoming calls via the main phone line via a mobile application ,Liaise with appointed vendors and building management to perform regular routine office ", 2800, "System" }
                });

            migrationBuilder.InsertData(
                table: "Resume",
                columns: new[] { "Id", "Certificates", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Education", "School", "UpdatedBy", "UserId", "User_Name" },
                values: new object[,]
                {
                    { 3, "Certificate of High Achievment in 3D modelling", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "Higher Nitec in Electronics", "ITE Central", null, null, "Danial bin Sulfian" },
                    { 2, "Food Hygiene certificate , MITx Manufacturing Program ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://196034-584727-raikfcquaxqncofqfm.stackpathdns.com/wp-content/uploads/2018/01/Electrician-Resume-723x1024.jpg", "Diploma in Food Science", "Singapore Polytechnic", null, null, "Dai Koi Yim" },
                    { 1, "Profesional ceritication of professional Achievment in Digital Media", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://resumegenius.com/wp-content/uploads/2019/07/Hostess-Resume-Sample-Template.png ", "Degree of  BSc Digital Media ", "Singapore of Social Science", null, null, "Luong Hao Wen" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Age", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Password", "UpdatedBy", "UserName" },
                values: new object[,]
                {
                    { 2, "127@gmail.com", 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ngiam Fabian", "Password2", null, "username222" },
                    { 1, "126@gmail.com", 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lonk How Wank", "Password1", null, "username111" }
                });

            migrationBuilder.InsertData(
                table: "company",
                columns: new[] { "Id", "CompanyName", "CreatedBy", "DateCreated", "DateUpdated", "Description", "HRStaffID", "JobPostingId", "PostingID", "UpdatedBy" },
                values: new object[,]
                {
                    { 6, "Daiso", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(675), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(676), "Daiso Industries Co., Ltd. is a large franchise of 100-yen shops founded in Japan. The headquarters are in Higashihiroshima, Hiroshima Prefecture. Daiso has a range of over 100,000 products, of which over 40 percent are imported goods, many of them from China, South Korea, and Japan.", 6, null, 6, "System" },
                    { 5, "Spotify", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(672), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(673), "Spotify is a Swedish audio streaming and media services provider founded on 23 April 2006 by Daniel Ek and Martin Lorentzon. It is one of the largest music streaming service providers with over 406 million monthly active users, including 180 million paying subscribers, as of December 2021", 5, null, 5, "System" },
                    { 4, "Popular Holdings", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(669), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(670), "Popular Holdings Limited, more commonly known as just Popular or colloquially as the Popular Bookstore, is a Singaporean multinational bookstore chain. Aside from Singapore, it also has subsidiaries in countries such as Canada, China, Malaysia and the United Kingdom.", 4, null, 4, "System" },
                    { 3, "ADECCO PERSONNEL PTE LTD", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(666), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(667), "For more than 35 years, Adecco provides a comprehensive array of HR solutions and consulting services which includes mid to staff level talentacquisition, contract recruitment, outsourcing, field sales and marketing as well as payroll services.Our expertise includes accounting & finance, admin & secretarial, banking, digital & eCommerce. ", 3, null, 3, "System" },
                    { 2, "ALVAS FOOD MANUFACTURE PTE LTD", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(663), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(664), "ALVAS FOOD MANUFACTURE PTE. LTD. is located in Singapore, Singapore and is part of the Dairy Product Manufacturing Industry. ALVAS FOOD MANUFACTURE PTE. LTD. has 8 total employees across all of its locations. (Employees figure is modelled).", 2, null, 2, "System" },
                    { 1, "LGA TELECOM PTE LTD", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(651), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(658), "As one of the industry’s digital pioneers, LGA has been helping shape Singapore’s digital ecosystem since 1995, starting first as a Digital Service Provider to now providing full digital solutions for businesses throughout Singapore.", 1, null, 1, "System" }
                });

            migrationBuilder.InsertData(
                table: "JobApplications",
                columns: new[] { "Id", "Comment", "CreatedBy", "DateCreated", "DateUpdated", "JobPostingID", "UpdatedBy", "UserNameId", "UserResume", "User_Name" },
                values: new object[,]
                {
                    { 1, "very good", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9256), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9262), 1, "System", null, "", "Luong Hao Wen" },
                    { 2, "very good", "System", new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 2, 8, 17, 9, 59, 19, DateTimeKind.Local).AddTicks(9267), 2, "System", null, "Very good at comptur mr ngiam", "Yew Yong Chank" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "JobPostingID", "Rating", "ReviewComment", "UpdatedBy", "UserNameId", "User_Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 8, 17, 9, 59, 17, DateTimeKind.Local).AddTicks(547), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(2263), 1, 3, "As soon as COVID-19 was getting serious, Indeed was one of the first companies to implement a mandatory work-from-home policy. Our healthy and safety came first, and I felt so lucky our company had the opportunity to make that decision. Since the WFH policy, our CEO, COO, and SVP of HR have been INCREDIBLE with transparency, being here for us and communicating to us more than I've ever seen.", "System", null, "Jim Jimson" },
                    { 2, "System", new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3205), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3210), 2, 4, "We have unlimited PTO, and we are encouraged to take it. 401K match up to 3%. Great healthcare plan. Our NYC office is beautiful with fully stocked drinks and snacks. There's a gym and multiple terraces.  We have company happy hours once a month and our holiday parties are OUTSTANDING. ", "System", null, "Danial Bin Sulfian" },
                    { 3, "System", new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3213), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3213), 2, 4, "Management tries to be inclusive and they provide training to ensure that employees are inclusive as they go about their work. The work can be challenging, and depending on your department, employees get lots of support. ", "System", null, "Yew Yong Chang" },
                    { 4, "System", new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3216), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3217), 2, 4, "Company tries to be inclusive and they provide training to ensure that employees are inclusive as they go about their work. The work can be challenging, and depending on your department, employees get lots of support. ", "System", null, "Yew Yong Chang" },
                    { 5, "System", new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3219), new DateTime(2022, 2, 8, 17, 9, 59, 18, DateTimeKind.Local).AddTicks(3220), 2, 2, "Since being remote the communication is horrible! If your supervisor doesn’t know, you will be lost! The other supervisors take forever to respond because they have their own team to help. Also the vibe, unless you are a TOP agent. They do NOT care about you.", "System", null, "Yeo Chen Si" }
                });

            migrationBuilder.InsertData(
                table: "SkillSets",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "IndividSkillsID", "JobPostingId", "PostingID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9646), 1, null, 1, "System" },
                    { 2, "System", new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9649), new DateTime(2022, 2, 8, 17, 9, 59, 20, DateTimeKind.Local).AddTicks(9651), 2, null, 2, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_company_JobPostingId",
                table: "company",
                column: "JobPostingId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_JobPostingID",
                table: "JobApplications",
                column: "JobPostingID");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_UserNameId",
                table: "JobApplications",
                column: "UserNameId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Resume_UserId",
                table: "Resume",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_JobPostingID",
                table: "Review",
                column: "JobPostingID");

            migrationBuilder.CreateIndex(
                name: "IX_Review_UserNameId",
                table: "Review",
                column: "UserNameId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSets_IndividSkillsID",
                table: "SkillSets",
                column: "IndividSkillsID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillSets_JobPostingId",
                table: "SkillSets",
                column: "JobPostingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Resume");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "SkillSets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "IndividSkills");

            migrationBuilder.DropTable(
                name: "JobPosting");
        }
    }
}
