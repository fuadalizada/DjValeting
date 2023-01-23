using AutoMapper;
using DjValeting.Business.DTOs;
using DjValeting.Business.Services.Abstract;
using DjValeting.DAL.Repositories.Abstract;
using DjValeting.DAL.ViewModels;
using DjValeting.Domain.Entities;

namespace DjValeting.Business.Services.Concrete
{
    public class AuthenticateService : BaseService<AuthenticateDto, Authenticate, IAuthenticateRepository>, IAuthenticateService
    {
        private readonly IAuthenticateRepository _authenticateRepository;
        private readonly IMapper _mapper;

        public AuthenticateService(IAuthenticateRepository repository, IMapper mapper) : base(repository, mapper)
        {
            _authenticateRepository = repository;
            _mapper = mapper;
        }

        public async Task<AuthenticateDto> Authenticate(LoginViewModel model)
        {
            var response = await _authenticateRepository.Authenticate(model);
            return _mapper.Map<AuthenticateDto>(response);
        }
    }
}
