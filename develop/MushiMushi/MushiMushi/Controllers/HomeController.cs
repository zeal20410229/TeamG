using Microsoft.AspNetCore.Mvc;
using MushiMushi.Models;
using System.Diagnostics;

namespace MushiMushi.Controllers
{
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

        public IActionResult contact()
        {
            return View();
        }
        public IActionResult account_info()
        {
            return View();
        }
        public IActionResult contact_comp()
        {
            return View();
        }
        public IActionResult douga_kanri()
        {
            return View();
        }
        public IActionResult illust_list()
        {
            return View();
        }
        public IActionResult illust_toukou()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        public IActionResult nouka_account()
        {
            return View();
        }
        public IActionResult nouka_sinki()
        {
            return View();
        }
        public IActionResult nouka_top()
        {
            return View();
        }
        public IActionResult nouka_toukou()
        {
            return View();
        }
        public IActionResult nouka_toukou_comp()
        {
            return View();
        }
        public IActionResult password_sinki()
        {
            return View();
        }
        public IActionResult toukou_illust_list()
        {
            return View();
        }
        public IActionResult toukou_videolist()
        {
            return View();
        }
        public IActionResult videolist()
        {
            return View();
        }
        public IActionResult kodomo_sityou()
        {
            return View();
        }
        public IActionResult douga_papurika()
        {
            return View();
        }
        public IActionResult toukou_comp()
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