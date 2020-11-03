using BigCatTechExam.Models.Interfaces;
using BigCatTechExam.Repository.Interfaces;
using BigCatTechExam.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigCatTechExam.Services.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationRepository _authenticationRepository;

        public AuthenticationService(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }

        public bool LogginSuccess(ISiteUser siteUser)
        {
            return _authenticationRepository.LoginSuccess(siteUser).Result;
        }
    }
}
