using BigCatTechExam.Models.Interfaces;
using BigCatTechExam.Repository.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using BigCatTechExam.Models.Models;
using System.Threading.Tasks;
using System.Text;

namespace BigCatTechExam.Repository.Repository
{
    public class BikeRepository : IBikeRepository
    {
        private static readonly string apiUrl = "http://localhost:3000/bikes/";
        private static readonly HttpClient client = new HttpClient();

        public async Task<IEnumerable<IBike>> GetAllBikes()
        {
            IEnumerable<IBike> bikeList;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    bikeList = JsonConvert.DeserializeObject<List<Bike>>(apiResponse);
                }
            }

            return bikeList;
        }

        public async Task<IBike> GetBike(long id)
        {
            IBike bike;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"{apiUrl}{id}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    bike = JsonConvert.DeserializeObject<Bike>(apiResponse);
                }
            }

            return bike;
        }

        public async Task UpdateBike(IBike bike)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(bike), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync($"{apiUrl}{bike.id}", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
        }

        public async Task AddBike(IBike bike)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(bike), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync($"{apiUrl}", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
