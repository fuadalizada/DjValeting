using DjValeting.DAL.ViewModels;
using DjValeting.Domain.Entities;

namespace DjValeting.DAL.Repositories.Abstract
{
    public interface IAuthenticateRepository : IBaseRepository<Authenticate>
    {
        Task<Authenticate> Authenticate(LoginViewModel model);
    }
}
