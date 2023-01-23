using AutoMapper;
using DjValeting.Business.DTOs;
using DjValeting.Business.Services.Abstract;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.Business.Services.Concrete
{
    public class FlexibilityService : BaseService<FlexibilityDto, Flexibility, IFlexibilityRepository>, IFlexibilityService
    {
        public FlexibilityService(IFlexibilityRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override async Task<IQueryable<FlexibilityDto>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
