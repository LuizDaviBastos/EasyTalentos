using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyTalentos.Repositorio.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Candidatos",
                columns: new[] { "Id", "Cidade", "Email", "Estado", "Linkedin", "Nome", "Portfolio", "PretencaoSalario", "Telefone" },
                values: new object[,]
                {
                    { 1, "Rio Grande do Sul", "Lesojo@outlook.com", "SP", "http://linkedin.com", "Buvimugae", "http://portfolio.com", 4298.0, "(21) 95930-3353" },
                    { 2, "Alagoas", "SHylyjae@outlook.com", "DF", "http://linkedin.com", "Kenaepizhae", "http://portfolio.com", 1742.0, "(13) 94571-3712" },
                    { 3, "Bahia", "Naecaexae@hotmail.com", "BA", "http://linkedin.com", "Jokeqasu", "http://portfolio.com", 1561.0, "(11) 94561-9958" },
                    { 4, "Espírito Santo", "Seqyka@outlook.com", "MT", "http://linkedin.com", "Qaetaridi", "http://portfolio.com", 1269.0, "(36) 96113-7597" },
                    { 5, "Pernambuco", "ZHamapae@outlook.com", "AC", "http://linkedin.com", "Majibopae", "http://portfolio.com", 3474.0, "(23) 99881-6426" },
                    { 6, "Distrito Federal", "Haravy@hotmail.com", "GO", "http://linkedin.com", "Girylaeha", "http://portfolio.com", 3130.0, "(33) 95836-7560" },
                    { 7, "Piauí", "Cygejy@outlook.com", "BA", "http://linkedin.com", "Mymocula", "http://portfolio.com", 4721.0, "(33) 94176-8341" },
                    { 8, "Paraíba", "Lebuje@outlook.com", "PA", "http://linkedin.com", "Qiveluwe", "http://portfolio.com", 3820.0, "(31) 95924-3470" },
                    { 9, "Espírito Santo", "Jaxuta@hotmail.com", "RJ", "http://linkedin.com", "SHytiwylo", "http://portfolio.com", 1211.0, "(14) 98138-9526" },
                    { 10, "Pará", "Guvaeha@outlook.com", "AM", "http://linkedin.com", "Vajigyxi", "http://portfolio.com", 4107.0, "(38) 91289-2781" }
                });

            migrationBuilder.InsertData(
                table: "Conhecimento",
                columns: new[] { "Id", "Android", "Angular", "AngularJs", "AspNetMvc", "AspNetWebForm", "Bootstrap", "C", "CSharp", "Cake", "CandidatoId", "Css", "DJango", "ExpressNodeJs", "Flask", "Flutter", "Html", "Illustrator", "Ionic", "Ios", "Java", "Jquery", "Laravel", "LinkCrud", "Majento", "MySql", "MySqlServer", "NodeJs", "Outras", "Photoshop", "Php", "Python", "ReactJs", "ReactNative", "Ruby", "SalesForce", "Seo", "Swift", "Vue", "WordPress" },
                values: new object[,]
                {
                    { 1, 1, 3, 2, 4, 4, 3, 4, 0, 1, 1, 1, 2, 3, 4, 1, 3, 2, 2, 2, 3, 4, 0, "http://linkcrud.com", 0, 3, 4, 4, "(Outras linguagens)", 2, 3, 4, 3, 1, 3, 0, 0, 4, 0, 3 },
                    { 7, 4, 1, 3, 4, 2, 3, 4, 3, 1, 7, 1, 0, 0, 0, 1, 3, 2, 4, 2, 0, 4, 3, "http://linkcrud.com", 1, 2, 0, 3, "(Outras linguagens)", 3, 0, 0, 3, 3, 1, 0, 1, 3, 0, 0 },
                    { 6, 4, 3, 4, 3, 3, 3, 0, 0, 3, 6, 1, 1, 1, 2, 3, 3, 0, 4, 1, 4, 2, 0, "http://linkcrud.com", 0, 1, 3, 1, "(Outras linguagens)", 0, 1, 0, 3, 3, 2, 4, 2, 2, 0, 1 },
                    { 5, 1, 0, 3, 4, 4, 2, 2, 2, 4, 5, 2, 4, 3, 3, 1, 1, 2, 2, 2, 2, 4, 4, "http://linkcrud.com", 0, 1, 0, 2, "(Outras linguagens)", 4, 3, 3, 3, 4, 3, 3, 4, 1, 2, 3 },
                    { 9, 4, 1, 1, 0, 2, 3, 4, 0, 3, 9, 1, 2, 0, 4, 4, 4, 0, 2, 1, 1, 3, 0, "http://linkcrud.com", 1, 3, 1, 1, "(Outras linguagens)", 3, 2, 0, 4, 4, 1, 2, 0, 4, 4, 2 },
                    { 4, 1, 4, 3, 0, 2, 1, 2, 1, 1, 4, 2, 4, 1, 2, 4, 4, 1, 2, 2, 4, 4, 3, "http://linkcrud.com", 3, 0, 2, 4, "(Outras linguagens)", 1, 0, 4, 4, 3, 3, 2, 4, 2, 4, 1 },
                    { 8, 2, 2, 1, 4, 4, 1, 0, 0, 4, 8, 1, 3, 0, 2, 2, 3, 3, 4, 3, 0, 1, 1, "http://linkcrud.com", 1, 1, 1, 2, "(Outras linguagens)", 0, 0, 0, 4, 4, 2, 0, 1, 3, 2, 4 },
                    { 2, 4, 3, 2, 2, 4, 3, 0, 3, 1, 2, 2, 3, 1, 1, 3, 1, 4, 4, 2, 1, 4, 0, "http://linkcrud.com", 4, 1, 0, 3, "(Outras linguagens)", 0, 3, 1, 2, 3, 4, 2, 0, 3, 0, 1 },
                    { 10, 4, 1, 1, 1, 0, 2, 3, 1, 0, 10, 4, 4, 4, 4, 1, 3, 0, 3, 1, 3, 1, 2, "http://linkcrud.com", 4, 1, 2, 1, "(Outras linguagens)", 2, 3, 3, 2, 1, 1, 0, 1, 1, 2, 4 },
                    { 3, 1, 1, 3, 1, 0, 3, 4, 0, 4, 3, 1, 3, 4, 2, 4, 4, 1, 3, 3, 4, 3, 1, "http://linkcrud.com", 0, 3, 2, 1, "(Outras linguagens)", 2, 2, 2, 3, 1, 3, 1, 2, 4, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Disponibilidade",
                columns: new[] { "Id", "AcimaDeOito", "AteQuatro", "CandidatoId", "FinaisDeSemana", "QuatroAteSeis", "SeisAteOito" },
                values: new object[,]
                {
                    { 3, false, false, 3, false, false, false },
                    { 9, false, false, 9, false, false, false },
                    { 8, false, false, 8, false, false, false },
                    { 2, false, false, 2, false, false, false },
                    { 5, false, false, 5, false, false, false },
                    { 10, false, false, 10, false, false, false },
                    { 6, false, false, 6, false, false, false },
                    { 1, false, false, 1, false, false, false },
                    { 7, false, false, 7, false, false, false },
                    { 4, false, false, 4, false, false, false }
                });

            migrationBuilder.InsertData(
                table: "Preferencia",
                columns: new[] { "Id", "CandidatoId", "Comercial", "Madrugada", "Manha", "Noite", "Tarde" },
                values: new object[,]
                {
                    { 9, 9, false, false, false, false, false },
                    { 8, 8, false, false, false, false, false },
                    { 5, 5, false, false, false, false, false },
                    { 6, 6, false, false, false, false, false },
                    { 4, 4, false, false, false, false, false },
                    { 3, 3, false, false, false, false, false },
                    { 2, 2, false, false, false, false, false },
                    { 1, 1, false, false, false, false, false },
                    { 7, 7, false, false, false, false, false },
                    { 10, 10, false, false, false, false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Conhecimento",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Disponibilidade",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Preferencia",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Candidatos",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
