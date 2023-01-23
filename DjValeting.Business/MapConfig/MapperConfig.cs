using AutoMapper;
using DjValeting.Business.DTOs;
using DjValeting.Domain.Entities;

namespace DjValeting.Business.MapConfig
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<BookingFormDto, BookingForm>().ReverseMap();
            CreateMap<FlexibilityDto, Flexibility>().ReverseMap();
            CreateMap<VehicleSizeDto, VehicleSize>().ReverseMap();
            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<UserRoleMappingDto, UserRoleMapping>().ReverseMap();
        }
    }
}
