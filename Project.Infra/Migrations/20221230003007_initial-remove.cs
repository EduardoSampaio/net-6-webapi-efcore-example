using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Migrations
{
    public partial class initialremove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "tbl_funcionarios");

            migrationBuilder.DropColumn(
                name: "DataEntrada",
                table: "tbl_funcionarios");

            migrationBuilder.DropColumn(
                name: "DataSaida",
                table: "tbl_funcionarios");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "tbl_funcionarios");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "tbl_funcionarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "tbl_funcionarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataEntrada",
                table: "tbl_funcionarios",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataSaida",
                table: "tbl_funcionarios",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "tbl_funcionarios",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "tbl_funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
