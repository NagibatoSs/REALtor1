using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REALtor1._2.Data.Interfaces;
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
            houses.currPerson = "Владелец";
            return View(houses);
        }
        public ViewResult MainView()
        {
            ViewBag.Title = "Главная страница";
            return View();
        }
    }
}
