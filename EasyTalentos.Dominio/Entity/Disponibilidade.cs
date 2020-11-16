using System.Text.Json.Serialization;


namespace EasyTalentos.Dominio.Entity
{
    public class Disponibilidade
    {
        public int Id { get; set; }

        public bool AteQuatro { get; set; }
        public bool QuatroAteSeis { get; set; }
        public bool SeisAteOito { get; set; }
        public bool AcimaDeOito { get; set; }
        public bool FinaisDeSemana { get; set; }

        public int CandidatoId { get; set; }


        [JsonIgnore]
        public virtual Candidato Candidato { get; set; }
    }
}
