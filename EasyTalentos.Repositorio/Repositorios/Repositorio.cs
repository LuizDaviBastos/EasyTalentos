using EasyTalentos.Dominio.Consulta;
using EasyTalentos.Dominio.Contratos;
using EasyTalentos.Repositorio.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using X.PagedList;

namespace EasyTalentos.Repositorio.Repositorios
{
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> _dbSet;

        public Repositorio(EasyContext banco)
        {
            _dbSet = banco.Set<TEntity>();
        }

        public void Adicionar(TEntity entity) => _dbSet.Add(entity);

        public void Atualizar(TEntity entity) => _dbSet.Update(entity);

        public TEntity Buscar(int id) => _dbSet.Find(id);

        public void Excluir(int id) => _dbSet.Remove(Buscar(id));


        public IEnumerable<TEntity> Obter(ref QueryParams queryParams)
        {
            var result = _dbSet.ToPagedList(queryParams.Pagina, queryParams.TamanhoPagina);
            queryParams.TotalRegistro = result.TotalItemCount;

            return result.ToList();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> expression, ref QueryParams queryParams)
        {
            var result = _dbSet.Where(expression)
               .ToPagedList(queryParams.Pagina, queryParams.TamanhoPagina);
            queryParams.TotalRegistro = result.TotalItemCount;

            return result.ToList();
        }
    }
}
