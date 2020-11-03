using BigCatTechExam.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigCatTechExam.Services.Interfaces
{
    public interface IAuthenticationService
    {
        bool LogginSuccess(ISiteUser siteUser);
    }
}
