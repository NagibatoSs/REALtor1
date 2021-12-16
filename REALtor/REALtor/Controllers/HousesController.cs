using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REALtor.Data.Interfaces;

namespace REALtor.Controllers
{
    public class HousesController: Controller
    {
        private readonly IAllHouses _allHouses;
        public HousesController(IAllHouses iAllHouses)
        {
            _allHouses = iAllHouses;
        }
        public ViewResult ListAllHouses()
        {
            ViewBag.Title = "Страница с недвижимостью";
            return View();
        }
    }
}
