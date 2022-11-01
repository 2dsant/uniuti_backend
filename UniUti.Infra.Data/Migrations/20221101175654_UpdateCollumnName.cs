using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniUti.Infra.Data.Migrations
{
    public partial class UpdateCollumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Monitorias",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "tipo_solicitacao",
                table: "Monitorias",
                newName: "Tipo_solicitacao");

            migrationBuilder.RenameColumn(
                name: "status_solicitacao",
                table: "Monitorias",
                newName: "Status_solicitacao");

            migrationBuilder.RenameColumn(
                name: "descricao",
                table: "Monitorias",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Monitorias",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Monitorias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Logs",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Logs",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Logs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Instituicoes",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Instituicoes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Instituicoes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Instituicoes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "deletado",
                table: "Instituicoes",
                newName: "Deletado");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Instituicoes",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "Instituicoes",
                newName: "Celular");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Instituicoes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "EnderecosUsuario",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "rua",
                table: "EnderecosUsuario",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "pais",
                table: "EnderecosUsuario",
                newName: "Pais");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "EnderecosUsuario",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "EnderecosUsuario",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "deletado",
                table: "EnderecosUsuario",
                newName: "Deletado");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "EnderecosUsuario",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "EnderecosUsuario",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "EnderecosUsuario",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "EnderecosUsuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "EnderecosInstituicao",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "rua",
                table: "EnderecosInstituicao",
                newName: "Rua");

            migrationBuilder.RenameColumn(
                name: "pais",
                table: "EnderecosInstituicao",
                newName: "Pais");

            migrationBuilder.RenameColumn(
                name: "numero",
                table: "EnderecosInstituicao",
                newName: "Numero");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "EnderecosInstituicao",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "deletado",
                table: "EnderecosInstituicao",
                newName: "Deletado");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "EnderecosInstituicao",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "cidade",
                table: "EnderecosInstituicao",
                newName: "Cidade");

            migrationBuilder.RenameColumn(
                name: "cep",
                table: "EnderecosInstituicao",
                newName: "Cep");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "EnderecosInstituicao",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Disciplinas",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Disciplinas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "deletado",
                table: "Disciplinas",
                newName: "Deletado");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Disciplinas",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Disciplinas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Cursos",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cursos",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "deletado",
                table: "Cursos",
                newName: "Deletado");

            migrationBuilder.RenameColumn(
                name: "createdAt",
                table: "Cursos",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cursos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "nomeCompleto",
                table: "AspNetUsers",
                newName: "NomeCompleto");

            migrationBuilder.RenameColumn(
                name: "deletado",
                table: "AspNetUsers",
                newName: "Deletado");

            migrationBuilder.RenameColumn(
                name: "celular",
                table: "AspNetUsers",
                newName: "Celular");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Monitorias",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Tipo_solicitacao",
                table: "Monitorias",
                newName: "tipo_solicitacao");

            migrationBuilder.RenameColumn(
                name: "Status_solicitacao",
                table: "Monitorias",
                newName: "status_solicitacao");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Monitorias",
                newName: "descricao");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Monitorias",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Monitorias",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Logs",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Logs",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Logs",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Instituicoes",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Instituicoes",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Instituicoes",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Instituicoes",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Deletado",
                table: "Instituicoes",
                newName: "deletado");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Instituicoes",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "Instituicoes",
                newName: "celular");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Instituicoes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "EnderecosUsuario",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "EnderecosUsuario",
                newName: "rua");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "EnderecosUsuario",
                newName: "pais");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "EnderecosUsuario",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "EnderecosUsuario",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Deletado",
                table: "EnderecosUsuario",
                newName: "deletado");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EnderecosUsuario",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "EnderecosUsuario",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "EnderecosUsuario",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EnderecosUsuario",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "EnderecosInstituicao",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Rua",
                table: "EnderecosInstituicao",
                newName: "rua");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "EnderecosInstituicao",
                newName: "pais");

            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "EnderecosInstituicao",
                newName: "numero");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "EnderecosInstituicao",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Deletado",
                table: "EnderecosInstituicao",
                newName: "deletado");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "EnderecosInstituicao",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Cidade",
                table: "EnderecosInstituicao",
                newName: "cidade");

            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "EnderecosInstituicao",
                newName: "cep");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EnderecosInstituicao",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Disciplinas",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Disciplinas",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Deletado",
                table: "Disciplinas",
                newName: "deletado");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Disciplinas",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Disciplinas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Cursos",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cursos",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Deletado",
                table: "Cursos",
                newName: "deletado");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Cursos",
                newName: "createdAt");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cursos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NomeCompleto",
                table: "AspNetUsers",
                newName: "nomeCompleto");

            migrationBuilder.RenameColumn(
                name: "Deletado",
                table: "AspNetUsers",
                newName: "deletado");

            migrationBuilder.RenameColumn(
                name: "Celular",
                table: "AspNetUsers",
                newName: "celular");
        }
    }
}
