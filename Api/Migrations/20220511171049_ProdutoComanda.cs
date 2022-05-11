using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Api.Migrations
{
    public partial class ProdutoComanda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "TotalRecebido",
                table: "Caixa",
                type: "numeric",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CaixaId = table.Column<int>(type: "integer", nullable: false),
                    NumeroComanda = table.Column<int>(type: "integer", nullable: false),
                    DataFechamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Mesa = table.Column<string>(type: "text", nullable: true),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    UsuarioAbriuId = table.Column<int>(type: "integer", nullable: false),
                    UsuarioFechouId = table.Column<int>(type: "integer", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comanda_AspNetUsers_UsuarioAbriuId",
                        column: x => x.UsuarioAbriuId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comanda_AspNetUsers_UsuarioFechouId",
                        column: x => x.UsuarioFechouId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comanda_Caixa_CaixaId",
                        column: x => x.CaixaId,
                        principalTable: "Caixa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoComanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProdutoId = table.Column<int>(type: "integer", nullable: false),
                    ComandaId = table.Column<int>(type: "integer", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    PrecoUnitario = table.Column<decimal>(type: "numeric", nullable: false),
                    GarcomId = table.Column<int>(type: "integer", nullable: false),
                    AtendenteId = table.Column<int>(type: "integer", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoComanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoComanda_AspNetUsers_AtendenteId",
                        column: x => x.AtendenteId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoComanda_AspNetUsers_GarcomId",
                        column: x => x.GarcomId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoComanda_Comanda_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comanda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoComanda_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_CaixaId",
                table: "Comanda",
                column: "CaixaId");

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_UsuarioAbriuId",
                table: "Comanda",
                column: "UsuarioAbriuId");

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_UsuarioFechouId",
                table: "Comanda",
                column: "UsuarioFechouId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComanda_AtendenteId",
                table: "ProdutoComanda",
                column: "AtendenteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComanda_ComandaId",
                table: "ProdutoComanda",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComanda_GarcomId",
                table: "ProdutoComanda",
                column: "GarcomId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoComanda_ProdutoId",
                table: "ProdutoComanda",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoComanda");

            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.DropColumn(
                name: "TotalRecebido",
                table: "Caixa");
        }
    }
}
