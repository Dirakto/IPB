using Microsoft.AspNetCore.Mvc;
using ipb.Models;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace ipb.Controllers
{
    public class DzialKaraniaController : Controller
    {

        private IAppRepository repo;
        private ILogger _logger;


        public DzialKaraniaController(IAppRepository repository, ILoggerFactory logger){
            _logger = logger.CreateLogger<HomeController>();
            repo = repository;
        }

        public IActionResult Index(){
            return View("Dzial", repo.Listy().Where(l => (l.Kategoria == Kategoria.DzialKarania) && (l.Stan != Stan.Rozpatrzony) && l.CzyPowazny).ToList() );
        }

        public IActionResult CheckList(int id){
            _logger.LogError(id+"");
            var list = repo.Listy().Where(l => l.Id == id).First();
            return View("List", new DzialWrapper(list));
        }

        public IActionResult Decyzja(DzialWrapper dw){
            if(dw.Equals("Winny")){
                _logger.LogError("Winny");
            }else{
                _logger.LogError("Niewinny");
            }

            var list = repo.Listy().Where(l => l.Id == dw.List.Id).First();
            list.Stan = Stan.Rozpatrzony;
            _logger.LogError(list.Stan+"");
            repo.UpdateList(list);
            repo.Save();

            return View("Dzial", repo.Listy().Where(l => (l.Kategoria == Kategoria.DzialKarania) && (l.Stan != Stan.Rozpatrzony)).ToList());
        }


        public IActionResult Niepowazny(int id){
            var list = repo.Listy().Where(l => l.Id == id).First();
            list.CzyPowazny = false;
            repo.UpdateList(list);
            repo.Save();
            return RedirectToAction("Index");
        }

    }
}