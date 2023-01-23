using AutoMapper;
using DjValeting.Business.DTOs;
using DjValeting.Business.Services.Abstract;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.Business.Services.Concrete
{
    public class BookingFormService : BaseService<BookingFormDto, BookingForm, IBookingFormRepository>, IBookingFormService
    {
        private readonly IBookingFormRepository _bookingFormRepository;
        private readonly IMapper _mapper;

        public BookingFormService(IBookingFormRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _bookingFormRepository = repository;
            _mapper = mapper;
        }

        public override async Task<IQueryable<BookingFormDto>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
