using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VOD.UI.Models;
using Microsoft.AspNetCore.Identity;
using VOD.Common.Entities;
using VOD.Database.Services;

namespace VOD.UI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private SignInManager<VODUser> _signInManager;
        private IDbReadService _db;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public HomeController(SignInManager<VODUser> signInMgr)
        {
            _signInManager = signInMgr;
            //, IDbReadService db
            //_db = db;
        }

        public async Task<IActionResult> Index()
        {
            //_db.Include<Download>();
            //_db.Include<Module, Course>();

            //var result1 = await _db.SingleAsync<Download>(d => d.Id.Equals(3));

            //var result2 = await _db.GetAsync<Download>(); //Fetch all

            //var result3 = await _db.GetAsync<Download>(d => d.ModuleId.Equals(1)); //Fetch all that matches the lambda expression

            //var result4 = await _db.AnyAsync<Download>(d => d.ModuleId.Equals(1)); //True if a record is found
            if (!_signInManager.IsSignedIn(User))
                return RedirectToPage("/Account/Login", new { Area = "Identity" });

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
