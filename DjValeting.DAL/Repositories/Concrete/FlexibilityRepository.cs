using DjValeting.DAL.DbContext;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.DAL.Repositories.Concrete
{
    public class FlexibilityRepository : BaseRepository<Flexibility>, IFlexibilityRepository
    {
        public FlexibilityRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<IQueryable<Flexibility>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
