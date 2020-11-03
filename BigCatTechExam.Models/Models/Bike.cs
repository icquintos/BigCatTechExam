using BigCatTechExam.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigCatTechExam.Models.Models
{
    public class Bike : IBike
    {
        public long id { get; set; }
        public string CustomerName { get; set; }
        public DateTime CheckOutTime { get; set; }
        public DateTime? CheckInTime { get; set; }
        public string TotalTimeSpent
        {
            get
            {
                if (CheckInTime.HasValue)
                {
                    TimeSpan timeSpan = CheckInTime.Value.Subtract(CheckOutTime);
                    return $"{timeSpan:hh\\:mm\\:ss}";
                }
                else
                {
                    return "0";
                }

            }
        }
        public DateTime DateModified { get; set; }
    }
}
