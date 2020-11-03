using System;
using System.Collections.Generic;
using System.Text;

namespace BigChatTechExam.Models.Interfaces
{
    interface IBike
    {
        int id { get; set; }
        string CustomerName { get; set; }
        DateTime CheckOutTime { get; set; }
        DateTime CeckInTime { get; set; }
        int TotalTimeSpent { get; set; }
        DateTime DateModified { get; set; }
    }
}
