using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BigCatTechExam.Web.Models;
using BigCatTechExam.Services.Interfaces;
using BigCatTechExam.Models.Models;
using Microsoft.AspNetCore.Authorization;

namespace BigCatTechExam.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IBikeService _bikeService;

        public HomeController(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }

        public IActionResult Index()
        {
            var bikeList = new BikeListViewModel();
            bikeList.BikeList = _bikeService.GetAllBike();
            
            return View(bikeList);
        }

        public IActionResult Checkin(long id)
        {
            var bike = _bikeService.GetBike(id);

            bike.CheckInTime = bike.DateModified = DateTime.Now;

            _bikeService.UpdateBike(bike);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Checkout(long id)
        {
            var bikeViewModel = new BikeViewModel();
            bikeViewModel.Bike = _bikeService.GetBike(id);

            return View(bikeViewModel);
        }

        [HttpPost]
        public IActionResult Checkout(long id, string customerName)
        {
            var bikeViewModel = new BikeViewModel
            {
                Bike = new Bike
                {
                    id = id,
                    CustomerName = customerName,
                    DateModified = DateTime.Now,
                    CheckOutTime = DateTime.Now,
                    CheckInTime = null
                }
            };

            if (id == 0)
            {
                bikeViewModel.Bike.id = _bikeService.GetLastId();
                _bikeService.AddBike(bikeViewModel.Bike);
            }
            else
            {
                _bikeService.UpdateBike(bikeViewModel.Bike);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
