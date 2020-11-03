using BigCatTechExam.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigCatTechExam.Models.Models
{
    public class SiteUser : ISiteUser
    {
        public SiteUser(string username, string password)
        {
            UserName = username;
            Password = password;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
