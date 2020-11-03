using System;
using System.Collections.Generic;
using System.Text;

namespace BigCatTechExam.Models.Interfaces
{
    public interface ISiteUser
    {
        string UserName { get; set; }
        string Password { get; set; }
    }
}
