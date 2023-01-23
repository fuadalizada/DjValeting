using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.DAL.Repositories.Concrete
{
    public class BookingFormRepository : BaseRepository<BookingForm>, IBookingFormRepository
    {
        public BookingFormRepository(Microsoft.EntityFrameworkCore.DbContext context) : base(context)
        {

        }

        public override  async Task<IQueryable<BookingForm>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }
    }
}
