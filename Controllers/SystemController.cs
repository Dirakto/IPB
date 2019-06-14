using Microsoft.AspNetCore.Mvc;
using ipb.Models;
using Microsoft.Extensions.Logging;

namespace ipb.Controllers
{
    public class SystemController : Controller
    {

        private IAppRepository repo;
        private ILogger _logger;

        public SystemController(IAppRepository repository, ILoggerFactory logger){
             _logger = logger.CreateLogger<HomeController>();
            repo = repository;
        }

        public IActionResult Save(ListWrapper lw){
            lw.List.Stan = Stan.Przyjety;
            repo.AddList(lw.List);
            repo.Save();
            lw.canRender = true;
            return RedirectToAction("KlientView", "Home");
        }
    }
}