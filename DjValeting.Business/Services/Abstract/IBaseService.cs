namespace DjValeting.Business.Services.Abstract
{
    public interface IBaseService<TDto> where TDto : class, new()
    {
        Task<IQueryable<TDto>> GetAllAsync();
        Task<TDto> FindByIdAsync(Guid id);
        Task<TDto> AddAsync(TDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
