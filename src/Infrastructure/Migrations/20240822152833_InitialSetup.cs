using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GMapsMagicianAPI.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Query",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ActiveScraper = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GMapsSearchLink = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsInstant = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: true),
                    RawQuery = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Query", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QueryResult",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Link = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QueryId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueryResult_Query_QueryId",
                        column: x => x.QueryId,
                        principalTable: "Query",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QueryStatusHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ScrapingConclusionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QueryId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueryStatusHistory_Query_QueryId",
                        column: x => x.QueryId,
                        principalTable: "Query",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QueryResultStatusHistory",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ScrapingConclusionDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QueryResultId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UUId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryResultStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QueryResultStatusHistory_QueryResult_QueryResultId",
                        column: x => x.QueryResultId,
                        principalTable: "QueryResult",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Query_UUId",
                table: "Query",
                column: "UUId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QueryResult_QueryId",
                table: "QueryResult",
                column: "QueryId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryResult_UUId",
                table: "QueryResult",
                column: "UUId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QueryResultStatusHistory_QueryResultId",
                table: "QueryResultStatusHistory",
                column: "QueryResultId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryResultStatusHistory_UUId",
                table: "QueryResultStatusHistory",
                column: "UUId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QueryStatusHistory_QueryId",
                table: "QueryStatusHistory",
                column: "QueryId");

            migrationBuilder.CreateIndex(
                name: "IX_QueryStatusHistory_UUId",
                table: "QueryStatusHistory",
                column: "UUId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QueryResultStatusHistory");

            migrationBuilder.DropTable(
                name: "QueryStatusHistory");

            migrationBuilder.DropTable(
                name: "QueryResult");

            migrationBuilder.DropTable(
                name: "Query");
        }
    }
}
