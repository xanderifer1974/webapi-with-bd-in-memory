using System.Linq.Expressions;

namespace ChatWeb.Trainning.DomainCore.Base
{
    public interface IDomainGenericRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> SelecionarTodos(Expression<Func<TEntity, bool>> quando = null);
        Task<TEntity> SelecionarPorId(TKey Id);
        Task Inserir(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Excluir(TEntity entity);
        Task ExcluirPorId(TKey Id);

    }
}
