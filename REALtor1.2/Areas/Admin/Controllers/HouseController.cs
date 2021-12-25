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


namespace REALtor1._2.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class HouseController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public HouseController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
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
                //if (imgFile != null)
                //{
                //    model.Img = imgFile.FileName;
                //    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "img/", imgFile.FileName), FileMode.Create))
                //    {
                //        imgFile.CopyTo(stream);
                //    }
                //}
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
