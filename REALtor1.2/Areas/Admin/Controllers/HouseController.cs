using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using REALtor1._2.Data;
using REALtor1._2.Data.Models;
using Microsoft.AspNetCore.Hosting;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.ViewModels;

namespace REALtor1._2.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HouseController : Controller
    {
        private readonly DataManager dataManager;
        public HouseController(DataManager dataManager)
        {
            this.dataManager = dataManager;

        }
        public ViewResult ListHouses()
        {
            ViewBag.Title = "Поиск";
            HousesListViewModel houses = new HousesListViewModel();
            houses.getAllHouses = dataManager.Houses.Houses;
            return View(houses);
        }
        public ViewResult MainView()
        {
            ViewBag.Title = "Главная страница";
            return View();
        }

        [HttpPost]
        public ViewResult ListHousesFiltr(House filtrHouse)
        {
            HousesListViewModel houses = new HousesListViewModel();
            houses.getAllHouses = dataManager.Houses.Houses
                .Where(n => n.Available == true)
                .Where(n => n.CountOfRooms == filtrHouse.CountOfRooms && n.Square >= filtrHouse.Square && n.Price >= filtrHouse.Price)
                .Where(n => n.coldWater == true && filtrHouse.coldWater == true)
                .Where(n => n.hotWater == true && filtrHouse.hotWater == true)
                .Where(n => n.electricity == true && filtrHouse.electricity == true)
                .Where(n => n.gas == true && filtrHouse.gas == true)
                .Where(n => n.Area == filtrHouse.Area && n.Area != null)
                .Where(n => n.StatusOfHome == filtrHouse.StatusOfHome && n.StatusOfHome != null)
                .Select(n => n);
            return View(houses);
        }
        public ViewResult ListHousesFiltr()
        {
            return View();
        }
        public IActionResult Parametrs()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var entity = id == default ? new House() : dataManager.Houses.getObjectHouse(id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(House model, IFormFile imgFile)
        {
            if (ModelState.IsValid)
            {
                dataManager.Houses.SaveHouse(model);
                return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller",""));
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            dataManager.Houses.DeleteHouse(id);
            return RedirectToAction(nameof(HomeController.Index), nameof(HomeController).Replace("Controller",""));
        }
    }
}
