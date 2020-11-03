using BigCatTechExam.Models.Interfaces;
using BigCatTechExam.Repository.Interfaces;
using BigCatTechExam.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigCatTechExam.Services.Services
{
    public class BikeService : IBikeService
    {
        private readonly IBikeRepository _bikeRepository;

        public BikeService(IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public IEnumerable<IBike> GetAllBike()
        {
           return _bikeRepository.GetAllBikes().Result;
        }

        public IBike GetBike(long id)
        {
            return _bikeRepository.GetBike(id).Result;
        }

        public void UpdateBike(IBike bike)
        {
            _bikeRepository.UpdateBike(bike).Wait();
        }

        public void AddBike(IBike bike)
        {
            _bikeRepository.AddBike(bike).Wait();
        }

        public long GetLastId()
        {
            return GetAllBike().Max(x => x.id) + 1;
        }
    }
}
