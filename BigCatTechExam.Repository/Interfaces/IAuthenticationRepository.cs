using BigCatTechExam.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BigCatTechExam.Repository.Interfaces
{
    public interface IAuthenticationRepository
    {
        Task<bool> LoginSuccess(ISiteUser siteUser);
    }
}
