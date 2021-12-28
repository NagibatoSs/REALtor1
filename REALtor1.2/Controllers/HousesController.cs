using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REALtor1._2.Data;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.Data.Models;
using REALtor1._2.ViewModels;

namespace REALtor1._2.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class HousesController:Controller
    {
        private readonly DataManager dataManager;
        public HousesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ViewResult ListHouses()
        {
            ViewBag.Title = "Поиск";
            HousesListViewModel houses = new HousesListViewModel();
            houses.getAllHouses = dataManager.Houses.Houses
                .Where(n=>n.Available==true);
            return View(houses);
        }
        //[HttpPost("FiltrList")]
        public IActionResult ListHousesFiltr(House filtrHouse)
        {
            if (filtrHouse != null)
            {
                HousesListViewModel houses = new HousesListViewModel();
                houses.getAllHouses = dataManager.Houses.Houses
                    .Where(n => n.Available == true)
                    .Where(n => n.CountOfRooms == filtrHouse.CountOfRooms)
                    .Where(n => n.Square >= filtrHouse.Square)
                    .Where(n => n.Price >= filtrHouse.Price)
                    .Where(n => n.coldWater == true && filtrHouse.coldWater == true)
                    .Where(n => n.hotWater == true && filtrHouse.hotWater == true)
                    .Where(n => n.electricity == true && filtrHouse.electricity == true)
                    .Where(n => n.gas == true && filtrHouse.gas == true)
                    .Where(n => n.Area == filtrHouse.Area && n.Area != null)
                    .Where(n => n.StatusOfHome == filtrHouse.StatusOfHome && n.StatusOfHome != null)
                    .Select(n => n);
                return View(houses);
            }
            else return NotFound("House filtr equals null");
        }
        public ViewResult ListHousesFiltr()
        {
            return View();
        }
       // [HttpGet("MainView")]
        public ViewResult MainView()
        {
            ViewBag.Title = "Главная страница";
            return View();
        }
        public IActionResult Parametrs()
        {
            return View();
        }

    }
}
