using EasyTalentos.Dominio.Consulta;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace EasyTalentos.Dominio.Contratos
{
    public interface IRepositorio<TEntity>
    {
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Excluir(int id);

        TEntity Buscar(int id);
        IEnumerable<TEntity> Obter(ref QueryParams queryParams);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> expression, ref QueryParams queryParams);


    }
}
