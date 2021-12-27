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
            houses.getAllHouses = _allHouses.Houses
                .Where(n=>n.Available==true);
            return View(houses);
        }
        [HttpPost]
        public ViewResult ListHousesFiltr(House filtrHouse)
        {
            HousesListViewModel houses = new HousesListViewModel();
            houses.getAllHouses = _allHouses.Houses
                .Where(n => n.Available==true)
                .Where(n => n.CountOfRooms == filtrHouse.CountOfRooms && n.Square >= filtrHouse.Square && n.Price >= filtrHouse.Price)
                .Where(n => n.coldWater==true && filtrHouse.coldWater==true)
                .Where(n => n.hotWater==true && filtrHouse.hotWater==true)
                .Where(n => n.electricity==true && filtrHouse.electricity==true)
                .Where(n => n.gas==true && filtrHouse.gas==true)
                .Where(n => n.Area==filtrHouse.Area && n.Area!=null)
                .Where(n => n.StatusOfHome==filtrHouse.StatusOfHome && n.StatusOfHome!=null)
                .Select(n => n);
            return View(houses);
        }
        public ViewResult ListHousesFiltr()
        {
            return View();
        }
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
