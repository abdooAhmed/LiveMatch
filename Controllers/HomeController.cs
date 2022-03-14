using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnMatch.Data;
using OnMatch.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace OnMatch.Controllers
{
    public class HomeController : Controller

    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext applicationDb;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbcontext)
        {
            _logger = logger;
            applicationDb = dbcontext;
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

        [HttpGet("{Id}")]
        public IActionResult Matches(string Id)
        {
            var dateTime = DateTime.Parse(Id);
            var mathches = applicationDb.Matches.Where(e => e.date.Date == dateTime).Include(e => e.club1).Include(e => e.club2).Include(e => e.league).Include(e => e.serverName).ToList();
            ViewData["date"] = Id;
           
            return View(mathches);
        }

        [HttpGet]
        public IActionResult Matches()
        {
            var mathches =  applicationDb.Matches.Where(e =>e.date.Date==DateTime.Now.Date).Include(e=>e.club1).Include(e=>e.club2).Include(e=>e.league).Include(e=>e.serverName).ToList();
            ViewData["date"] = DateTime.Now.Date.ToString("MM-dd-yyyy");
            return View(mathches);
        }
        [HttpGet]
        public IActionResult Live(int Id)
        {
            var match = applicationDb.Matches.Where(e=>e.Id==Id).Include(e => e.club1).Include(e => e.club2).Include(e => e.league).Include(e => e.serverName).Include(e => e.serverName.serverLinks).FirstOrDefault();
            
            return View(match);
        }
    }
}
