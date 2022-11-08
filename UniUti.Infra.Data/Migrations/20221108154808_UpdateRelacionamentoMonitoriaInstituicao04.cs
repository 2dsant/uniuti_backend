using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniUti.Infra.Data.Migrations
{
    public partial class UpdateRelacionamentoMonitoriaInstituicao04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monitorias_Instituicoes_InstituicaoId",
                table: "Monitorias");

            migrationBuilder.DropIndex(
                name: "IX_Monitorias_InstituicaoId",
                table: "Monitorias");

            migrationBuilder.DropColumn(
                name: "InstituicaoId",
                table: "Monitorias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "InstituicaoId",
                table: "Monitorias",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Monitorias_InstituicaoId",
                table: "Monitorias",
                column: "InstituicaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Monitorias_Instituicoes_InstituicaoId",
                table: "Monitorias",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "Id");
        }
    }
}
