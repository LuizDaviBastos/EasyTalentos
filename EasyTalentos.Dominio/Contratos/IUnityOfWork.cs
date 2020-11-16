using EasyTalentos.Dominio.Entity;

namespace EasyTalentos.Dominio.Contratos
{
    public interface IUnityOfWork
    {
        IRepositorio<Candidato> CandidatoRepositorio { get; }

        void SaveChanges();
    }
}
