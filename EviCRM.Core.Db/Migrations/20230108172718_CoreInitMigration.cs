using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace EviCRM.Core.Db.Migrations
{
    /// <inheritdoc />
    public partial class CoreInitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,")
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LocalPath = table.Column<string>(type: "text", nullable: true),
                    NetworkPath = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Sender = table.Column<int>(type: "integer", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Avatar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LocalPath = table.Column<string>(type: "text", nullable: true),
                    NetworkPath = table.Column<string>(type: "text", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avatar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalendarVisual",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CalendarId = table.Column<string>(type: "text", nullable: false),
                    Code = table.Column<string>(type: "text", nullable: false),
                    Color = table.Column<string>(type: "text", nullable: false),
                    ForeColor = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarVisual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Cast = table.Column<List<Guid>>(type: "uuid[]", nullable: false),
                    Head = table.Column<Guid>(type: "uuid", nullable: true),
                    Avatar = table.Column<Guid>(type: "uuid", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Health",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: true),
                    HttpCode = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeyStore",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Command = table.Column<string>(type: "text", nullable: false),
                    Value1 = table.Column<string>(type: "text", nullable: true),
                    Value2 = table.Column<string>(type: "text", nullable: true),
                    Value3 = table.Column<string>(type: "text", nullable: true),
                    Value4 = table.Column<string>(type: "text", nullable: true),
                    Value5 = table.Column<string>(type: "text", nullable: true),
                    Value6 = table.Column<string>(type: "text", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyStore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsCat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NewsTag",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    BasedOnRole = table.Column<Guid>(type: "uuid", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Telegram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ChatId = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telegram", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsPersonal = table.Column<bool>(type: "boolean", nullable: false),
                    IsSecret = table.Column<bool>(type: "boolean", nullable: false),
                    Key = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chat_Avatar_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Head = table.Column<Guid>(type: "uuid", nullable: true),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Avatar_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Head = table.Column<Guid>(type: "uuid", nullable: true),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Avatar_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Details = table.Column<string>(type: "text", nullable: true),
                    StartProject = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndProject = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Cast = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    DivCast = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    BoundTasks = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Avatar_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CalendarId = table.Column<Guid>(type: "uuid", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Body = table.Column<string>(type: "text", nullable: true),
                    IsInOffice = table.Column<bool>(type: "boolean", nullable: false),
                    IsNotify = table.Column<bool>(type: "boolean", nullable: false),
                    NotifyPeriod = table.Column<int>(type: "integer", nullable: false),
                    VisualCalendarTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    Attachments = table.Column<List<Guid?>>(type: "uuid[]", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendar_CalendarVisual_VisualCalendarTypeId",
                        column: x => x.VisualCalendarTypeId,
                        principalTable: "CalendarVisual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    DivisionId = table.Column<Guid>(type: "uuid", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Position_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Location = table.Column<Point>(type: "geography (point)", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsPublic = table.Column<bool>(type: "boolean", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkdownCard",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TitleImageId = table.Column<Guid>(type: "uuid", nullable: true),
                    BackColorHex = table.Column<string>(type: "text", nullable: true),
                    TaskBoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeskBoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkdownCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarkdownCard_Attachment_TitleImageId",
                        column: x => x.TitleImageId,
                        principalTable: "Attachment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MarkdownDesk",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PersonalBoundId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsPersonal = table.Column<bool>(type: "boolean", nullable: false),
                    TaskBoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkdownDesk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkdownTodo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TaskBoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsChecked = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CardBoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarkEvent = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkdownTodo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarkdownTodo_MarkdownCard_CardBoundId",
                        column: x => x.CardBoundId,
                        principalTable: "MarkdownCard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Headline = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    Tags = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    NewsAvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsArchived = table.Column<bool>(type: "boolean", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    DivisionsMentioned = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Avatar_NewsAvatarId",
                        column: x => x.NewsAvatarId,
                        principalTable: "Avatar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_News_NewsCat_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "NewsCat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Token = table.Column<string>(type: "text", nullable: true),
                    TimeToken = table.Column<string>(type: "text", nullable: true),
                    Fullname = table.Column<string>(type: "text", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    PositionId = table.Column<Guid>(type: "uuid", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: true),
                    DivisionId = table.Column<Guid>(type: "uuid", nullable: true),
                    Skills = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    MobilePhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: false),
                    ExperienceS1 = table.Column<string>(type: "text", nullable: true),
                    ExperienceS2 = table.Column<string>(type: "text", nullable: true),
                    TotalRevenue = table.Column<double>(type: "double precision", nullable: true),
                    Revenue = table.Column<double>(type: "double precision", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastLogin = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastAction = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastActivity = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TelegramId = table.Column<Guid>(type: "uuid", nullable: true),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsActivated = table.Column<bool>(type: "boolean", nullable: false),
                    AvatarId = table.Column<Guid>(type: "uuid", nullable: true),
                    ThinClientUsing = table.Column<string>(type: "text", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true),
                    NewsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Avatar_AvatarId",
                        column: x => x.AvatarId,
                        principalTable: "Avatar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Telegram_TelegramId",
                        column: x => x.TelegramId,
                        principalTable: "Telegram",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NewsComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    NewsBoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderId = table.Column<Guid>(type: "uuid", nullable: false),
                    InReply = table.Column<bool>(type: "boolean", nullable: false),
                    ReplyCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsComment_NewsComment_ReplyCommentId",
                        column: x => x.ReplyCommentId,
                        principalTable: "NewsComment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewsComment_News_NewsBoundId",
                        column: x => x.NewsBoundId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsComment_User_SenderId",
                        column: x => x.SenderId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FactEndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Attachments = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    Budget = table.Column<string>(type: "text", nullable: true),
                    Members = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    ResponsibleMembers = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsNotify = table.Column<bool>(type: "boolean", nullable: false),
                    ProjectsBound = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    PersonalStatusCollection = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    Divisions = table.Column<List<Guid>>(type: "uuid[]", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_User_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TelegramPush",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ChatId = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelegramPush", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TelegramPush_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkingDays",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SubjectUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StartWork = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EndWork = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkingDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkingDays_User_SubjectUserId",
                        column: x => x.SubjectUserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PersonalStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BoundTaskId = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalStatus_Task_BoundTaskId",
                        column: x => x.BoundTaskId,
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalStatus_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTrackingEvent",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Command = table.Column<int>(type: "integer", nullable: false),
                    Variable1 = table.Column<string>(type: "text", nullable: false),
                    Variable2 = table.Column<string>(type: "text", nullable: true),
                    Variable3 = table.Column<string>(type: "text", nullable: true),
                    Variable4 = table.Column<string>(type: "text", nullable: true),
                    Variable5 = table.Column<string>(type: "text", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    TaskBoundId = table.Column<Guid>(type: "uuid", nullable: false),
                    CardBoundId = table.Column<Guid>(type: "uuid", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTrackingEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskTrackingEvent_MarkdownCard_CardBoundId",
                        column: x => x.CardBoundId,
                        principalTable: "MarkdownCard",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TaskTrackingEvent_Task_TaskBoundId",
                        column: x => x.TaskBoundId,
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTrackingEvent_User_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskTrackingComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false),
                    SourceEventId = table.Column<Guid>(type: "uuid", nullable: false),
                    InReplyCommentId = table.Column<Guid>(type: "uuid", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTrackingComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskTrackingComment_TaskTrackingEvent_SourceEventId",
                        column: x => x.SourceEventId,
                        principalTable: "TaskTrackingEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskTrackingComment_User_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendar_VisualCalendarTypeId",
                table: "Calendar",
                column: "VisualCalendarTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_AvatarId",
                table: "Chat",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AvatarId",
                table: "Company",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_AvatarId",
                table: "Department",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Map_AuthorId",
                table: "Map",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownCard_DeskBoundId",
                table: "MarkdownCard",
                column: "DeskBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownCard_TaskBoundId",
                table: "MarkdownCard",
                column: "TaskBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownCard_TitleImageId",
                table: "MarkdownCard",
                column: "TitleImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownDesk_PersonalBoundId",
                table: "MarkdownDesk",
                column: "PersonalBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownDesk_TaskBoundId",
                table: "MarkdownDesk",
                column: "TaskBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownTodo_CardBoundId",
                table: "MarkdownTodo",
                column: "CardBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkdownTodo_TaskBoundId",
                table: "MarkdownTodo",
                column: "TaskBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_News_NewsAvatarId",
                table: "News",
                column: "NewsAvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsComment_NewsBoundId",
                table: "NewsComment",
                column: "NewsBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsComment_ReplyCommentId",
                table: "NewsComment",
                column: "ReplyCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsComment_SenderId",
                table: "NewsComment",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalStatus_BoundTaskId",
                table: "PersonalStatus",
                column: "BoundTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalStatus_UserId",
                table: "PersonalStatus",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_CompanyId",
                table: "Position",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Position_DivisionId",
                table: "Position",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_AvatarId",
                table: "Project",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_AuthorId",
                table: "Task",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTrackingComment_AuthorId",
                table: "TaskTrackingComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTrackingComment_SourceEventId",
                table: "TaskTrackingComment",
                column: "SourceEventId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTrackingEvent_AuthorId",
                table: "TaskTrackingEvent",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTrackingEvent_CardBoundId",
                table: "TaskTrackingEvent",
                column: "CardBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskTrackingEvent_TaskBoundId",
                table: "TaskTrackingEvent",
                column: "TaskBoundId");

            migrationBuilder.CreateIndex(
                name: "IX_TelegramPush_UserId",
                table: "TelegramPush",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AvatarId",
                table: "User",
                column: "AvatarId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyId",
                table: "User",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DepartmentId",
                table: "User",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_User_DivisionId",
                table: "User",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_NewsId",
                table: "User",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PositionId",
                table: "User",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_TelegramId",
                table: "User",
                column: "TelegramId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkingDays_SubjectUserId",
                table: "WorkingDays",
                column: "SubjectUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Map_User_AuthorId",
                table: "Map",
                column: "AuthorId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownCard_MarkdownDesk_DeskBoundId",
                table: "MarkdownCard",
                column: "DeskBoundId",
                principalTable: "MarkdownDesk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownCard_Task_TaskBoundId",
                table: "MarkdownCard",
                column: "TaskBoundId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownDesk_Task_TaskBoundId",
                table: "MarkdownDesk",
                column: "TaskBoundId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownDesk_User_PersonalBoundId",
                table: "MarkdownDesk",
                column: "PersonalBoundId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MarkdownTodo_Task_TaskBoundId",
                table: "MarkdownTodo",
                column: "TaskBoundId",
                principalTable: "Task",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_User_AuthorId",
                table: "News",
                column: "AuthorId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Avatar_AvatarId",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Avatar_AvatarId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Avatar_NewsAvatarId",
                table: "News");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Avatar_AvatarId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_News_User_AuthorId",
                table: "News");

            migrationBuilder.DropTable(
                name: "Calendar");

            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Health");

            migrationBuilder.DropTable(
                name: "KeyStore");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropTable(
                name: "MarkdownTodo");

            migrationBuilder.DropTable(
                name: "NewsComment");

            migrationBuilder.DropTable(
                name: "NewsTag");

            migrationBuilder.DropTable(
                name: "PersonalStatus");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "TaskTrackingComment");

            migrationBuilder.DropTable(
                name: "TelegramPush");

            migrationBuilder.DropTable(
                name: "WorkingDays");

            migrationBuilder.DropTable(
                name: "CalendarVisual");

            migrationBuilder.DropTable(
                name: "TaskTrackingEvent");

            migrationBuilder.DropTable(
                name: "MarkdownCard");

            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "MarkdownDesk");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "Avatar");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Telegram");

            migrationBuilder.DropTable(
                name: "NewsCat");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Division");
        }
    }
}
