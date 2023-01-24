using AutoMapper;
using DjValeting.Business.DTOs;
using DjValeting.Business.Services.Abstract;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.Business.Services.Concrete
{
    public class BookingFormService : BaseService<BookingFormDto, BookingForm, IBookingFormRepository>, IBookingFormService
    {
        public BookingFormService(IBookingFormRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public override async Task<IQueryable<BookingFormDto>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        public override async Task<BookingFormDto> AddAsync(BookingFormDto dto)
        {
            return await base.AddAsync(dto);
        }

        public override async Task<bool> DeleteAsync(Guid id)
        {
            return await base.DeleteAsync(id);
        }
    }
}
