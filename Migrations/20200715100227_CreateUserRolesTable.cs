using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserAuthenticationAPI.Migrations
{
    public partial class CreateUserRolesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleType = table.Column<string>(type: "varchar(255)", nullable: false),
                    RolePriority = table.Column<string>(type: "varchar(255)", nullable: false),
                    CreatorId = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
