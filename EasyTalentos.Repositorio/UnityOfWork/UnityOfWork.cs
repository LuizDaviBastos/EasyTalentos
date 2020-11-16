using EasyTalentos.Dominio.Contratos;
using EasyTalentos.Dominio.Entity;
using EasyTalentos.Repositorio.DataBase;
using EasyTalentos.Repositorio.Repositorios;
using System;

namespace EasyTalentos.Repositorio.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private Repositorio<Candidato> _candidatoRepositorio = null;

        private readonly EasyContext _banco;

        public UnityOfWork(EasyContext banco)
        {
            _banco = banco;
        }

        public IRepositorio<Candidato> CandidatoRepositorio
        {
            get
            {
                if (_candidatoRepositorio == null)
                    _candidatoRepositorio = new Repositorio<Candidato>(_banco);

                return _candidatoRepositorio;
            }
        }

        public void SaveChanges()
        {
            _banco.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _banco.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
