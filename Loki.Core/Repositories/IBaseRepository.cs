namespace Loki.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        ValueTask<TEntity?> GetAsync(int id);
    }
}