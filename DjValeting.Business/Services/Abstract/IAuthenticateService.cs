using DjValeting.Business.DTOs;
using DjValeting.DAL.ViewModels;

namespace DjValeting.Business.Services.Abstract
{
    public interface IAuthenticateService : IBaseService<AuthenticateDto>
    {
        Task<AuthenticateDto> Authenticate(LoginViewModel model);
    }
}
