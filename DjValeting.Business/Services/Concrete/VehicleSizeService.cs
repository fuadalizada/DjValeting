using AutoMapper;
using DjValeting.Business.DTOs;
using DjValeting.Business.Services.Abstract;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.Business.Services.Concrete
{
    public class VehicleSizeService : BaseService<VehicleSizeDto, VehicleSize, IVehicleSizeRepository>, IVehicleSizeService
    {
        public VehicleSizeService(IVehicleSizeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override async Task<IQueryable<VehicleSizeDto>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
