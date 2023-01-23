using AutoMapper;
using DjValeting.Business.Services.Abstract;
using DjValeting.DAL.Repositories.Abstract;

namespace DjValeting.Business.Services.Concrete
{
    public class BaseService<TDto, TEntity, TRepository> : IBaseService<TDto>
        where TDto : class, new()
        where TEntity : class, new()
        where TRepository : IBaseRepository<TEntity>
    {
        private readonly TRepository _repository;
        private readonly IMapper _mapper;

        public BaseService(TRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<TDto> AddAsync(TDto dto)
        {
            var request = _mapper.Map<TEntity>(dto);
            var response = await _repository.AddAsync(request);
            var result = _mapper.Map<TDto>(response);
            return result;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);
            return result;
        }

        public async Task<TDto> FindByIdAsync(Guid id)
        {
            var response = await _repository.FindByIdAsync(id);
            var result = _mapper.Map<TDto>(response);
            return result;
        }

        public async Task<IQueryable<TDto>> GetAllAsync()
        {
            var response = await _repository.GetAllAsync();
            var result = _mapper.ProjectTo<TDto>(response);
            return result;
        }
    }
}
