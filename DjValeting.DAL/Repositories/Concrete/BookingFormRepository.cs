using DjValeting.DAL.DbContext;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DjValeting.DAL.Repositories.Concrete
{
    public class BookingFormRepository : BaseRepository<BookingForm>, IBookingFormRepository
    {
        public BookingFormRepository(ApplicationDbContext context) : base(context)
        {

        }

        public override async Task<IQueryable<BookingForm>> GetAllAsync()
        {
            var result = await Context.Set<BookingForm>().Include(x=>x.Flexibility).Include(x=>x.VehicleSize).ToListAsync();
            return result.AsQueryable();
        }

        public override async Task<BookingForm> AddAsync(BookingForm entity)
        {
            return await base.AddAsync(entity);
        }

        public override async Task<bool> DeleteAsync(Guid id)
        {
            return await base.DeleteAsync(id);
        }

        public async Task<bool> ApproveForm(Guid id)
        {
            var result = await Context.Set<BookingForm>().Where(x=>x.Id == id).FirstOrDefaultAsync();
            result.IsActive = true;
            Context.Update(result);
            return await Context.SaveChangesAsync() > 0;            
        }
    }
}
