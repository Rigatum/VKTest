using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VKTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserState",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserState", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserGroupID = table.Column<Guid>(type: "uuid", nullable: false),
                    UserStateID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_UserGroups_UserGroupID",
                        column: x => x.UserGroupID,
                        principalTable: "UserGroups",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_UserState_UserStateID",
                        column: x => x.UserStateID,
                        principalTable: "UserState",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_UserGroupID",
                table: "User",
                column: "UserGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserStateID",
                table: "User",
                column: "UserStateID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "UserState");
        }
    }
}
