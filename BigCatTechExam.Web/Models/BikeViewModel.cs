using BigCatTechExam.Models.Interfaces;
using BigCatTechExam.Models.Models;

namespace BigCatTechExam.Web.Models
{
    public class BikeViewModel
    {
        public BikeViewModel()
        {
            Bike = new Bike();
        }

        public IBike Bike { get; set; }
    }
}
