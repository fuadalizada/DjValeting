using DjValeting.DAL.DbContext;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.DAL.ViewModels;
using DjValeting.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DjValeting.DAL.Repositories.Concrete
{
    public class AuthenticateRepository : BaseRepository<Authenticate>, IAuthenticateRepository
    {
        private readonly Microsoft.EntityFrameworkCore.DbContext _context;
        public AuthenticateRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Authenticate> Authenticate(LoginViewModel model)
        {
            var user = await _context.Set<User>().Where(x => x.Email == model.Email && x.IsActive).FirstOrDefaultAsync();

            if (user is not null)
            {
                if (BCrypt.Net.BCrypt.Verify(model.Password, user.PasswordHash))
                {
                    var userRoleMapping = await _context.Set<UserRoleMapping>().Where(x => x.UserId == user.Id && x.IsActive).FirstOrDefaultAsync();
                    if (userRoleMapping is not null)
                    {
                        if (userRoleMapping.Name is "Admin")
                        {
                            return new Authenticate { Response = true,RoleName = userRoleMapping.Name};
                        }
                        else
                        {
                            return new Authenticate { Response = true, RoleName = userRoleMapping.Name };
                        }
                    }
                }                
            }

            return new Authenticate { Response = false,RoleName = null};
        }
    }
}
