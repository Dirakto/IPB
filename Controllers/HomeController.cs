using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ipb.Models;

namespace ipb.Controllers
{
    public class HomeController : Controller
    {

        private static string LOGIN_OSKAR = "Oskar";
        private static string PASSWORD_OSKAR = "Rajzer";
        private static string LOGIN_PIOTR = "Piotr";
        private static string PASSWORD_PIOTR = "Pawlak";

        private IAppRepository repo;

        public HomeController(IAppRepository repository){
            repo = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginInfo li){
            if(li.Name.Equals(LOGIN_OSKAR) && li.Password.Equals(PASSWORD_OSKAR)){
                return View("Klient", new ListWrapper(repo.Listy()));
            }else if(li.Name.Equals(LOGIN_PIOTR) && li.Password.Equals(PASSWORD_PIOTR)){
                return RedirectToAction("Index", "DzialKarania");
            }else
            {
                return Json("Error");
            }
        }

        public IActionResult KlientView(ListWrapper lw){
            return View("Klient", new ListWrapper(repo.Listy()));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
