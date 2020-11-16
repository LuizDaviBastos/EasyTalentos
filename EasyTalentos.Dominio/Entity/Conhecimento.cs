using System.Text.Json.Serialization;

namespace EasyTalentos.Dominio.Entity
{
    public class Conhecimento
    {
        public int Id { get; set; }

        public int Ionic { get; set; }
        public int ReactJs { get; set; }
        public int ReactNative { get; set; }
        public int Android { get; set; }
        public int Flutter { get; set; }
        public int Swift { get; set; }
        public int Ios { get; set; }
        public int Html { get; set; }
        public int Css { get; set; }
        public int Bootstrap { get; set; }
        public int Jquery { get; set; }
        public int AngularJs { get; set; }
        public int Angular { get; set; }
        public int Java { get; set; }
        public int Python { get; set; }
        public int Flask { get; set; }
        public int AspNetMvc { get; set; }
        public int AspNetWebForm { get; set; }
        public int C { get; set; }
        public int CSharp { get; set; }
        public int NodeJs { get; set; }
        public int ExpressNodeJs { get; set; }
        public int Cake { get; set; }
        public int DJango { get; set; }
        public int Majento { get; set; }
        public int Php { get; set; }
        public int Vue { get; set; }
        public int WordPress { get; set; }
        public int Ruby { get; set; }
        public int MySqlServer { get; set; }
        public int MySql { get; set; }
        public int SalesForce { get; set; }
        public int Photoshop { get; set; }
        public int Illustrator { get; set; }
        public int Seo { get; set; }
        public int Laravel { get; set; }

        public string Outras { get; set; }

        public string LinkCrud { get; set; }

        public int CandidatoId { get; set; }

        [JsonIgnore]
        public virtual Candidato Candidato { get; set; }
    }
}
