using System.Diagnostics;
using EduManage.Web.Data;
using EduManage.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduManage.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly EduManageDbContext _db;

        public HomeController(EduManageDbContext db)
        {
            _db = db;
        }

        public IActionResult Others()
        {
            var item = new EduManageController(_db);
            return View();
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
    }
}
