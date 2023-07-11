using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using WebApplication2.Domain.Entities;
using WebApplication2.Domain.Repositories.Abstract;
using WebApplication2.Domain.Repositories.EntityFramework;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HeatController : Controller
    {

        private readonly EFHeatRepository eFHeatRepository;


        public HeatController(EFHeatRepository eFHeatRepository)
        {
            this.eFHeatRepository = eFHeatRepository;
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}



        public IActionResult Index()
        {
            var model = eFHeatRepository.GetHeats();
            return View(model);
            ;
        }
        public IActionResult HeatEdit(int id)
        {
            Heat_work model = id == default ? new Heat_work() : eFHeatRepository.GetHeatsById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult HeatEdit(Heat_work model)
        {
            if (ModelState.IsValid)
            {
                eFHeatRepository.SaveHeat(model);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        //[HttpPost]
        //public IActionResult HeatDelete( int id)
        //{
        //    eFHeatRepository.DeleteHeat(new Heat_work { Id = id });
        //    return RedirectToAction("Index");
        //}

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
