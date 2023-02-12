using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiveStarRepos.Infra.Dados.Repositories.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Repositorio",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Privado = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DataSincronizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCriacaoRepositorio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacaoRepositorio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tamanho = table.Column<long>(type: "bigint", nullable: false),
                    Stars = table.Column<long>(type: "bigint", nullable: false),
                    Linguagem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BranchPadrao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repositorio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dono",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RepositorioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dono", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dono_Repositorio_RepositorioId",
                        column: x => x.RepositorioId,
                        principalTable: "Repositorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Licenca",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RepositorioId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenca_Repositorio_RepositorioId",
                        column: x => x.RepositorioId,
                        principalTable: "Repositorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dono_RepositorioId",
                table: "Dono",
                column: "RepositorioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenca_RepositorioId",
                table: "Licenca",
                column: "RepositorioId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dono");

            migrationBuilder.DropTable(
                name: "Licenca");

            migrationBuilder.DropTable(
                name: "Repositorio");
        }
    }
}
