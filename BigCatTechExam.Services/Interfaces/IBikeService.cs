using BigCatTechExam.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BigCatTechExam.Services.Interfaces
{
    public interface IBikeService
    {
        IEnumerable<IBike> GetAllBike();
        IBike GetBike(long id);
        void UpdateBike(IBike bike);
        void AddBike(IBike bike);
        long GetLastId();
    }
}
