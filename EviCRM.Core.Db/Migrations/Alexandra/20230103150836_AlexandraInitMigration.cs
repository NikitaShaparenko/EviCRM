using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace EviCRM.Core.Db.Migrations.Alexandra
{
    /// <inheritdoc />
    public partial class AlexandraInitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,")
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    Lastname = table.Column<string>(type: "text", nullable: true),
                    MobilePhoneNumber = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: true),
                    VCard = table.Column<string>(type: "text", nullable: true),
                    Login = table.Column<string>(type: "text", nullable: true),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Location = table.Column<Point>(type: "geography (point)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    User = table.Column<Guid>(type: "uuid", nullable: true),
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
                name: "Poll",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Question = table.Column<string>(type: "text", nullable: false),
                    Explanations = table.Column<string>(type: "text", nullable: true),
                    IsMultipleAnswers = table.Column<bool>(type: "boolean", nullable: false),
                    IsAnon = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    MultipleAnswers = table.Column<string>(type: "jsonb", nullable: true),
                    Options = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: false),
                    CorrectOptionId = table.Column<string>(type: "text", nullable: false),
                    WhenInserted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhenUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    WhoInserted = table.Column<Guid>(type: "uuid", nullable: true),
                    WhoUpdated = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poll", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropTable(
                name: "Poll");
        }
    }
}
