using BigCatTechExam.Models.Interfaces;
using BigCatTechExam.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigCatTechExam.Web.Models
{
    public class BikeListViewModel
    {
        public BikeListViewModel()
        {
            BikeList = new List<Bike>();
        }

        public IEnumerable<IBike> BikeList { get; set; }
    }
}
