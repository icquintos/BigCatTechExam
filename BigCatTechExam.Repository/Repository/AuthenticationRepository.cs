using BigCatTechExam.Models.Interfaces;
using BigCatTechExam.Models.Models;
using BigCatTechExam.Repository.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BigCatTechExam.Repository.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private static readonly string apiUrl = "http://localhost:3000/account/";

        public async Task<bool> LoginSuccess(ISiteUser siteUser)
        {
            SiteUser resultSiteUser;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    resultSiteUser = JsonConvert.DeserializeObject<SiteUser>(apiResponse);
                }
            }

            return siteUser.UserName == resultSiteUser.UserName && siteUser.Password == resultSiteUser.Password;
        }
    }
}
