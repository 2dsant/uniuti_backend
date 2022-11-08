using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniUti.Infra.Data.Migrations
{
    public partial class MudancasEnderecoNaoObrigatorio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosInstituicao_Instituicoes_InstituicaoId",
                table: "EnderecosInstituicao");

            migrationBuilder.AlterColumn<Guid>(
                name: "InstituicaoId",
                table: "EnderecosInstituicao",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosInstituicao_Instituicoes_InstituicaoId",
                table: "EnderecosInstituicao",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EnderecosInstituicao_Instituicoes_InstituicaoId",
                table: "EnderecosInstituicao");

            migrationBuilder.AlterColumn<Guid>(
                name: "InstituicaoId",
                table: "EnderecosInstituicao",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EnderecosInstituicao_Instituicoes_InstituicaoId",
                table: "EnderecosInstituicao",
                column: "InstituicaoId",
                principalTable: "Instituicoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
