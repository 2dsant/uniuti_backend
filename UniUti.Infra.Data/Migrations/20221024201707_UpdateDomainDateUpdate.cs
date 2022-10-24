using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniUti.Infra.Data.Migrations
{
    public partial class UpdateDomainDateUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Monitorias",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Logs",
                newName: "createdAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Monitorias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdAt",
                table: "Logs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "Logs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Instituicoes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "Instituicoes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "EnderecosUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "EnderecosUsuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "EnderecosInstituicao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "EnderecosInstituicao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Disciplinas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "Disciplinas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Cursos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedAt",
                table: "Cursos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Monitorias");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Instituicoes");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Instituicoes");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "EnderecosUsuario");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "EnderecosUsuario");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "EnderecosInstituicao");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "EnderecosInstituicao");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Disciplinas");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "updatedAt",
                table: "Cursos");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Monitorias",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Logs",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Logs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
