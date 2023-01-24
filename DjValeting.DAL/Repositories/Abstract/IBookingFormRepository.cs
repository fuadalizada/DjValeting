using DjValeting.Domain.Entities;

namespace DjValeting.DAL.Repositories.Abstract
{
    public interface IBookingFormRepository : IBaseRepository<BookingForm>
    {
        Task<bool> ApproveForm(Guid id);
        Task<bool> UpdateForm(BookingForm form);
    }
}
