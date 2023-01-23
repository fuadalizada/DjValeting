using DjValeting.DAL.DbContext;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;

namespace DjValeting.DAL.Repositories.Concrete
{
    public class BookingFormRepository : BaseRepository<BookingForm>, IBookingFormRepository
    {
        public BookingFormRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override  async Task<IQueryable<BookingForm>> GetAllAsync()
        {
            return await base.GetAllAsync();
        }

        public override async Task<BookingForm> AddAsync(BookingForm entity)
        {
            return await base.AddAsync(entity);
        }
    }
}
