using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Controllers
{

    // release
    public class HomeController : Controller
    {
    
        private readonly ILogger<HomeController> _logger;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
        /// le code corrige 
        public int somme (int a,int b)
        {

            //hiba benchaira correction
            int s = 0;
            return s=a+b;
            //Amsaguine Oualid Correction 
            int somme ;
            somme = a+b ;
            return somme;


          //Wakach aymane correction de bug
            return a + b;
        }
    }
}
