using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyTalentos.Repositorio.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Linkedin = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Portfolio = table.Column<string>(nullable: true),
                    PretencaoSalario = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conhecimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ionic = table.Column<int>(nullable: false),
                    ReactJs = table.Column<int>(nullable: false),
                    ReactNative = table.Column<int>(nullable: false),
                    Android = table.Column<int>(nullable: false),
                    Flutter = table.Column<int>(nullable: false),
                    Swift = table.Column<int>(nullable: false),
                    Ios = table.Column<int>(nullable: false),
                    Html = table.Column<int>(nullable: false),
                    Css = table.Column<int>(nullable: false),
                    Bootstrap = table.Column<int>(nullable: false),
                    Jquery = table.Column<int>(nullable: false),
                    AngularJs = table.Column<int>(nullable: false),
                    Angular = table.Column<int>(nullable: false),
                    Java = table.Column<int>(nullable: false),
                    Python = table.Column<int>(nullable: false),
                    Flask = table.Column<int>(nullable: false),
                    AspNetMvc = table.Column<int>(nullable: false),
                    AspNetWebForm = table.Column<int>(nullable: false),
                    C = table.Column<int>(nullable: false),
                    CSharp = table.Column<int>(nullable: false),
                    NodeJs = table.Column<int>(nullable: false),
                    ExpressNodeJs = table.Column<int>(nullable: false),
                    Cake = table.Column<int>(nullable: false),
                    DJango = table.Column<int>(nullable: false),
                    Majento = table.Column<int>(nullable: false),
                    Php = table.Column<int>(nullable: false),
                    Vue = table.Column<int>(nullable: false),
                    WordPress = table.Column<int>(nullable: false),
                    Ruby = table.Column<int>(nullable: false),
                    MySqlServer = table.Column<int>(nullable: false),
                    MySql = table.Column<int>(nullable: false),
                    SalesForce = table.Column<int>(nullable: false),
                    Photoshop = table.Column<int>(nullable: false),
                    Illustrator = table.Column<int>(nullable: false),
                    Seo = table.Column<int>(nullable: false),
                    Laravel = table.Column<int>(nullable: false),
                    Outras = table.Column<string>(nullable: true),
                    LinkCrud = table.Column<string>(nullable: true),
                    CandidatoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conhecimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conhecimento_Candidatos_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Disponibilidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AteQuatro = table.Column<bool>(nullable: false),
                    QuatroAteSeis = table.Column<bool>(nullable: false),
                    SeisAteOito = table.Column<bool>(nullable: false),
                    AcimaDeOito = table.Column<bool>(nullable: false),
                    FinaisDeSemana = table.Column<bool>(nullable: false),
                    CandidatoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disponibilidade_Candidatos_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Preferencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manha = table.Column<bool>(nullable: false),
                    Tarde = table.Column<bool>(nullable: false),
                    Noite = table.Column<bool>(nullable: false),
                    Madrugada = table.Column<bool>(nullable: false),
                    Comercial = table.Column<bool>(nullable: false),
                    CandidatoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preferencia_Candidatos_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conhecimento_CandidatoId",
                table: "Conhecimento",
                column: "CandidatoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilidade_CandidatoId",
                table: "Disponibilidade",
                column: "CandidatoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preferencia_CandidatoId",
                table: "Preferencia",
                column: "CandidatoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conhecimento");

            migrationBuilder.DropTable(
                name: "Disponibilidade");

            migrationBuilder.DropTable(
                name: "Preferencia");

            migrationBuilder.DropTable(
                name: "Candidatos");
        }
    }
}
