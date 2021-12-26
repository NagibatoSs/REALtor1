using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.Data.Models;
using REALtor1._2.ViewModels;

namespace REALtor1._2.Controllers
{
    public class HousesController:Controller
    {
        private readonly IAllHouses _allHouses;
        private readonly IAllPerson _allPerson;
        public HousesController(IAllHouses iallHouses,IAllPerson iallPerson)
        {
            _allHouses = iallHouses;
            _allPerson = iallPerson;
        }
        public ViewResult ListHouses()
        {
            ViewBag.Title = "Поиск";
            HousesListViewModel houses = new HousesListViewModel();
            houses.getAllHouses = _allHouses.Houses;
            return View(houses);
        }
        public ViewResult MainView()
        {
            ViewBag.Title = "Главная страница";
            return View();
        }
        public IActionResult Parametrs(House house)
        {
            HousesListViewModel houses = new HousesListViewModel();
            houses.getAllHouses = _allHouses.Houses
                .Where(n =>
                    n.CountOfRooms == house.CountOfRooms
                    && n.coldWater == house.coldWater
                    && n.electricity == house.electricity
                    && n.gas == house.gas
                    && n.hotWater == house.hotWater
                    && n.Area == house.Area
                    && n.Available == true
                    && n.StatusOfHome == house.StatusOfHome
                    && n.Price <= house.Price
                    && n.Square <= house.Square)
                .Select(n => n);
            return View(houses);
        }

    }
}
