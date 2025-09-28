using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Passion.Migrations
{
    /// <inheritdoc />
    public partial class Passion : Migration
    {
        /// <inheritdoc />
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "MasterAboutUs",
                columns: table => new
                {
                    MasterAboutUsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterAboutUsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterAboutUsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterAboutUs", x => x.MasterAboutUsId);
                });

            migrationBuilder.CreateTable(
                name: "MasterChooseCategory",
                columns: table => new
                {
                    MasterChooseCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterChooseCategoryIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterChooseCategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterChooseCategoryBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterChooseCategory", x => x.MasterChooseCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "MasterContactUs",
                columns: table => new
                {
                    MasterContactUsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterContactUsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterContactUsPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterContactUsEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterContactUs", x => x.MasterContactUsId);
                });

            migrationBuilder.CreateTable(
                name: "MasterContactUsInformation",
                columns: table => new
                {
                    MasterContactUsInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterContactUsInformationIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterContactUsInformationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterContactUsInformation", x => x.MasterContactUsInformationId);
                });

            migrationBuilder.CreateTable(
                name: "MasterFeature",
                columns: table => new
                {
                    MasterFeatureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterFeatureTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFeatureBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFeatureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFeatureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFeatureImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFeature", x => x.MasterFeatureId);
                });

            migrationBuilder.CreateTable(
                name: "MasterFeatures",
                columns: table => new
                {
                    MasterFeaturesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterFeaturesIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFeaturesTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFeaturesBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFeaturesNumber = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFeatures", x => x.MasterFeaturesId);
                });

            migrationBuilder.CreateTable(
                name: "MasterFocus",
                columns: table => new
                {
                    MasterFocusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterFocusTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusQuickSetupIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusQuickSetupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusFullSecurityIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusFullSecurityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusMoneyBack = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusRatingIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusUsersIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterFocusImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterFocus", x => x.MasterFocusId);
                });

            migrationBuilder.CreateTable(
                name: "MasterHowWeWork",
                columns: table => new
                {
                    MasterHowWeWorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterHowWeWorkIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterHowWeWorkTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterHowWeWorkBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterHowWeWorkDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterHowWeWork", x => x.MasterHowWeWorkId);
                });

            migrationBuilder.CreateTable(
                name: "MasterMenu",
                columns: table => new
                {
                    MasterMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterMenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterMenuUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterMenu", x => x.MasterMenuId);
                });

            migrationBuilder.CreateTable(
                name: "MasterOurServices",
                columns: table => new
                {
                    MasterOurServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterOurServicesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterOurServicesUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterOurServices", x => x.MasterOurServicesId);
                });

            migrationBuilder.CreateTable(
                name: "MasterPartner",
                columns: table => new
                {
                    MasterPartnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterPartnerLogoImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPartnerWebsiteUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPartner", x => x.MasterPartnerId);
                });

            migrationBuilder.CreateTable(
                name: "MasterPortfolioCategoryMenu",
                columns: table => new
                {
                    MasterPortfolioCategoryMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterPortfolioCategoryMenuName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPortfolioCategoryMenu", x => x.MasterPortfolioCategoryMenuId);
                });

            migrationBuilder.CreateTable(
                name: "MasterPricing",
                columns: table => new
                {
                    MasterPricingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterPricingIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPricingTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPricingBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPricingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPricingUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPricing", x => x.MasterPricingId);
                });

            migrationBuilder.CreateTable(
                name: "MasterQuestions",
                columns: table => new
                {
                    MasterQuestionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterQuestionsIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterQuestionsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterQuestionsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterQuestions", x => x.MasterQuestionsId);
                });

            migrationBuilder.CreateTable(
                name: "MasterService",
                columns: table => new
                {
                    MasterServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterServiceProjectsCompleted = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServiceClientSatisfaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServiceSupportAvailable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServiceYearsExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterService", x => x.MasterServiceId);
                });

            migrationBuilder.CreateTable(
                name: "MasterServices",
                columns: table => new
                {
                    MasterServicesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterServicesIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsList1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsList2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsNeedHelpDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsNeedHelpIconPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsNeedHelpPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsNeedHelpIconEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsNeedHelpEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsNeedHelpUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsTitleImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsDescriptionWhatYouWillGet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterServicesDetailsDescriptionOurProcess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterServices", x => x.MasterServicesId);
                });

            migrationBuilder.CreateTable(
                name: "MasterSocialMedium",
                columns: table => new
                {
                    MasterSocialMediumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterSocialMediumIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterSocialMediumUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterSocialMedium", x => x.MasterSocialMediumId);
                });

            migrationBuilder.CreateTable(
                name: "MasterTeam",
                columns: table => new
                {
                    MasterTeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterTeamTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterTeamBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterTeamDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterTeamIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterTeamIconUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterTeamImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterTeam", x => x.MasterTeamId);
                });

            migrationBuilder.CreateTable(
                name: "MasterUsefullLinks",
                columns: table => new
                {
                    MasterUsefullLinksId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterUsefullLinksName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterUsefullLinksUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterUsefullLinks", x => x.MasterUsefullLinksId);
                });

            migrationBuilder.CreateTable(
                name: "MasterWhatPeopleSay",
                columns: table => new
                {
                    MasterWhatPeopleSayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterWhatPeopleSayTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterWhatPeopleSayBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterWhatPeopleSayDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterWhatPeopleSayImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterWhatPeopleSay", x => x.MasterWhatPeopleSayId);
                });

            migrationBuilder.CreateTable(
                name: "SystemSetting",
                columns: table => new
                {
                    SystemSettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemSetting", x => x.SystemSettingId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionContactUs",
                columns: table => new
                {
                    TransactionContactUsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionContactUsName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionContactUsEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionContactUsSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionContactUsMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionContactUs", x => x.TransactionContactUsId);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "MasterChooseItemMenu",
                columns: table => new
                {
                    MasterChooseItemMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterChooseCategoryId = table.Column<int>(type: "int", nullable: false),
                    MasterChooseItemMenuTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterChooseItemMenuBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterChooseItemMenuDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterChooseItemMenuList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterChooseItemMenuImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterChooseItemMenu", x => x.MasterChooseItemMenuId);
                    table.ForeignKey(
                        name: "FK_MasterChooseItemMenu_MasterChooseCategory_MasterChooseCategoryId",
                        column: x => x.MasterChooseCategoryId,
                        principalTable: "MasterChooseCategory",
                        principalColumn: "MasterChooseCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MasterPortfolioItemMenu",
                columns: table => new
                {
                    MasterPortfolioItemMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterPortfolioCategoryMenuId = table.Column<int>(type: "int", nullable: false),
                    MasterPortfolioItemMenuTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuBreef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsUrlCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsTechnologiesUsed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsActiveUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsClientSatisfaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsMonthsDevelopment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsAppStoreRating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsTheChallenge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsTheSolution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsFeatures1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsFeatures2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MasterPortfolioItemMenuDetailsFeatures3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EditUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EditDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPortfolioItemMenu", x => x.MasterPortfolioItemMenuId);
                    table.ForeignKey(
                        name: "FK_MasterPortfolioItemMenu_MasterPortfolioCategoryMenu_MasterPortfolioCategoryMenuId",
                        column: x => x.MasterPortfolioCategoryMenuId,
                        principalTable: "MasterPortfolioCategoryMenu",
                        principalColumn: "MasterPortfolioCategoryMenuId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_MasterChooseItemMenu_MasterChooseCategoryId",
                table: "MasterChooseItemMenu",
                column: "MasterChooseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPortfolioItemMenu_MasterPortfolioCategoryMenuId",
                table: "MasterPortfolioItemMenu",
                column: "MasterPortfolioCategoryMenuId");
        }

        /// <inheritdoc />
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
                name: "MasterAboutUs");

            migrationBuilder.DropTable(
                name: "MasterChooseItemMenu");

            migrationBuilder.DropTable(
                name: "MasterContactUs");

            migrationBuilder.DropTable(
                name: "MasterContactUsInformation");

            migrationBuilder.DropTable(
                name: "MasterFeature");

            migrationBuilder.DropTable(
                name: "MasterFeatures");

            migrationBuilder.DropTable(
                name: "MasterFocus");

            migrationBuilder.DropTable(
                name: "MasterHowWeWork");

            migrationBuilder.DropTable(
                name: "MasterMenu");

            migrationBuilder.DropTable(
                name: "MasterOurServices");

            migrationBuilder.DropTable(
                name: "MasterPartner");

            migrationBuilder.DropTable(
                name: "MasterPortfolioItemMenu");

            migrationBuilder.DropTable(
                name: "MasterPricing");

            migrationBuilder.DropTable(
                name: "MasterQuestions");

            migrationBuilder.DropTable(
                name: "MasterService");

            migrationBuilder.DropTable(
                name: "MasterServices");

            migrationBuilder.DropTable(
                name: "MasterSocialMedium");

            migrationBuilder.DropTable(
                name: "MasterTeam");

            migrationBuilder.DropTable(
                name: "MasterUsefullLinks");

            migrationBuilder.DropTable(
                name: "MasterWhatPeopleSay");

            migrationBuilder.DropTable(
                name: "SystemSetting");

            migrationBuilder.DropTable(
                name: "TransactionContactUs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MasterChooseCategory");

            migrationBuilder.DropTable(
                name: "MasterPortfolioCategoryMenu");
        }
    }
}
