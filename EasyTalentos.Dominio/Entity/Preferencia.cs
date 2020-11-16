using System.Text.Json.Serialization;

namespace EasyTalentos.Dominio.Entity
{
    public class Preferencia
    {
        public int Id { get; set; }

        public bool Manha { get; set; }
        public bool Tarde { get; set; }
        public bool Noite { get; set; }
        public bool Madrugada { get; set; }
        public bool Comercial { get; set; }

        public int CandidatoId { get; set; }

        [JsonIgnore]
        public virtual Candidato Candidato { get; set; }
    }
}
