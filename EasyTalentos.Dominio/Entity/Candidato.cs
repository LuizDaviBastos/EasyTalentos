using EasyTalentos.Dominio.Validacoes;



namespace EasyTalentos.Dominio.Entity
{

    public class Candidato
    {

        public int Id { get; set; }

        [Requirido]
        public string Nome { get; set; }

        [Requirido]
        public string Email { get; set; }

        [Requirido]
        public string Telefone { get; set; }

        public string Linkedin { get; set; }

        [Requirido]
        public string Cidade { get; set; }

        [Requirido]
        public string Estado { get; set; }

        public string Portfolio { get; set; }


        public virtual Disponibilidade Disponibilidade { get; set; }


        public virtual Preferencia Preferencia { get; set; }

        [Requirido]
        public double PretencaoSalario { get; set; }


        public virtual Conhecimento Conhecimento { get; set; }

    }
}
