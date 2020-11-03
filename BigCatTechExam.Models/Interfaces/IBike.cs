using System;
using System.Collections.Generic;
using System.Text;

namespace BigCatTechExam.Models.Interfaces
{
    public interface IBike
    {
        long id { get; set; }
        string CustomerName { get; set; }
        DateTime CheckOutTime { get; set; }
        DateTime? CheckInTime { get; set; }
        string TotalTimeSpent { get; }
        DateTime DateModified { get; set; }
    }
}
