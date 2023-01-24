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

        public override async Task<BookingFormDto> AddAsync(BookingFormDto dto)
        {
            return await base.AddAsync(dto);
        }

        public override async Task<bool> DeleteAsync(Guid id)
        {
            return await base.DeleteAsync(id);
        }

        public async Task<bool> ApproveForm(Guid id)
        {
            var result = await _bookingFormRepository.ApproveForm(id);
            return result;
        }

        public override async Task<BookingFormDto> FindByIdAsync(Guid id)
        {
            var response = await _bookingFormRepository.FindByIdAsync(id);
            var result = _mapper.Map<BookingFormDto>(response);
            return result;
        }

        public async Task<bool> UpdateForm(BookingFormDto formDto)
        {
            var response = _mapper.Map<BookingForm>(formDto);
            var result = await _bookingFormRepository.UpdateForm(response);
            return result;
        }
    }
}
