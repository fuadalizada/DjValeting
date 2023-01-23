namespace DjValeting.DAL.Repositories.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class, new()
    {
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity> FindByIdAsync(Guid id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
