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
            var result = await Context.Set<BookingForm>().Include(x => x.Flexibility).Include(x => x.VehicleSize).ToListAsync();
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
            var result = await Context.Set<BookingForm>().Where(x => x.Id == id).FirstOrDefaultAsync();
            result.IsActive = true;
            Context.Update(result);
            return await Context.SaveChangesAsync() > 0;
        }

        public override async Task<BookingForm> FindByIdAsync(Guid id)
        {
            var result = await Context.Set<BookingForm>().Include(x => x.Flexibility).Include(x => x.VehicleSize).SingleOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<bool> UpdateForm(BookingForm form)
        {
            var response = await Context.Set<BookingForm>().FindAsync(form.Id);
            if (response is not null)
            {
                response.Name = form.Name;
                response.CreateDate = form.CreateDate;
                response.Email = form.Email;
                response.FlexibilityId = form.FlexibilityId;
                response.VehicleSizeId = form.VehicleSizeId;
                response.IsActive = form.IsActive;
                response.ContactNumber = form.ContactNumber;
                Context.Update(response);
            }
            return await Context.SaveChangesAsync() > 0;
        }

        public async Task<string> GetClientEmail(Guid formId)
        {
            var result = await Context.Set<BookingForm>().Where(x=>x.Id == formId).Select(x => x.Email).FirstOrDefaultAsync();
            return result;
        }
    }
}
