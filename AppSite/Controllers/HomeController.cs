using AppModels;
using AppSite.Models;
using AppSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AppSite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public IUserService userApi;
        public HomeController(IUserService userApi)
        {
            this.userApi = userApi;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Users> x = await userApi.GetUsersService();
            return View(x);
        }

        public async Task<IActionResult> Info(int Id)
        {
            Users user = await userApi.GetUserByIdService(Id);
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            Users user = await userApi.GetUserByIdService(Id);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Users user)
        {
            Users result = await userApi.EditUserService(user);
            return RedirectToAction("Info",new { Id = result.Id });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
