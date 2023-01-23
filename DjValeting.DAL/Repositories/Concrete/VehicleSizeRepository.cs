using DjValeting.DAL.DbContext;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.DAL.Repositories.Concrete
{
    public class VehicleSizeRepository : BaseRepository<VehicleSize>, IVehicleSizeRepository
    {
        public VehicleSizeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public override async Task<IQueryable<VehicleSize>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
