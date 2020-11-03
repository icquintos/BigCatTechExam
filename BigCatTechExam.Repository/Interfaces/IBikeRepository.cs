using BigCatTechExam.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BigCatTechExam.Repository.Interfaces
{
    public interface IBikeRepository
    {
        Task<IEnumerable<IBike>> GetAllBikes();
        Task<IBike> GetBike(long id);
        Task UpdateBike(IBike bike);
        Task AddBike(IBike bike);
    }
}
