﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jcf.AM.Control.Api.Migrations
{
    /// <inheritdoc />
    public partial class UserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Login = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Role = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserCreateId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UserUpdateId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_UserCreateId",
                        column: x => x.UserCreateId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Users_UserUpdateId",
                        column: x => x.UserUpdateId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateAt", "Email", "IsActive", "Login", "Name", "Password", "Role", "UpdateAt", "UserCreateId", "UserUpdateId" },
                values: new object[,]
                {
                    { new Guid("08dbd59a-2683-4c67-8e16-689ba2648545"), new DateTime(2025, 5, 4, 22, 11, 22, 189, DateTimeKind.Local).AddTicks(3950), "admin@email.com", true, "admin@email.com", "Administrador Usuário", "670F8574BD93DD78BD568DAB84C6733A", "ADMIN", null, null, null },
                    { new Guid("08dbdc08-56e1-4e90-805f-db29361e075e"), new DateTime(2025, 5, 4, 22, 11, 22, 229, DateTimeKind.Local).AddTicks(4247), "basico@email.com", true, "basico@email.com", "Básico Usuário", "670F8574BD93DD78BD568DAB84C6733A", "BASIC", null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCreateId",
                table: "Users",
                column: "UserCreateId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserUpdateId",
                table: "Users",
                column: "UserUpdateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
