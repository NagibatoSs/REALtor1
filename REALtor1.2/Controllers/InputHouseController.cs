using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REALtor1._2.Data.Interfaces;
using REALtor1._2.Data.Models;

namespace REALtor1._2.Controllers
{
    public class InputHouseController:Controller
    {
        private readonly IAllHouses allHouses;
        public InputHouseController(IAllHouses all)
        {
            allHouses = all;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(House person)
        {
            if (ModelState.IsValid)
            {
                allHouses.createHouse(person);
                return RedirectToAction("Complete");
            }
            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Готово";
            return View();
        }
    }
}
