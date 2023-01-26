using DjValeting.Business.DTOs;

namespace DjValeting.Business.Services.Abstract
{
    public interface IBookingFormService : IBaseService<BookingFormDto>
    {
        Task<bool> ApproveForm(Guid id);
        Task<bool> UpdateForm(BookingFormDto formDto);
        Task<string> GetClientEmail(Guid formId);
    }
}
