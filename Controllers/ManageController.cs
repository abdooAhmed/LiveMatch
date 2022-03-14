using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnMatch.Data;
using OnMatch.Models;
using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnMatch.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private readonly ApplicationDbContext applicationDb;
        public ManageController(ApplicationDbContext dbcontext)
        {
            applicationDb = dbcontext;
        }
        [HttpGet]
        public IActionResult AddLeague()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddLeague(League league)
        {
            if (ModelState.IsValid)
            {
                using (var ms = new MemoryStream())
                {
                    league.Image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    league.Img = fileBytes;
                }
                applicationDb.Add(league);
                applicationDb.SaveChanges();
                return RedirectToAction("AddClub");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddClub()
        {
            ViewData["leagues"] = new SelectList(applicationDb.Leagues, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddClub(Club club)
        {
            if (ModelState.IsValid)
            {
                ViewData["leagues"] = new SelectList(applicationDb.Leagues, "Id", "Name");
                var league = applicationDb.Leagues.Where(e => e.Id == club.LeagueId);
                using (var ms = new MemoryStream())
                {
                    club.Image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    club.Img = fileBytes;
                }
                applicationDb.Add(club);
                applicationDb.SaveChanges();
                return View();
            }
            return View(club);
        }

        
        

        [HttpGet]
        public IActionResult AddMatch()
        {
            ViewData["clubs"] = new SelectList(applicationDb.Clubs, "Id", "Name");
            ViewData["ServerId"] = new SelectList(applicationDb.serverNames, "Id", "Name");
            ViewData["leagues"] = new SelectList(applicationDb.Leagues, "Id", "Name");
            return View();
        }

        [HttpGet]
        public IActionResult EditMatch(int Id)
        {
            ViewData["clubs"] = new SelectList(applicationDb.Clubs, "Id", "Name");
            ViewData["ServerId"] = new SelectList(applicationDb.serverNames, "Id", "Name");
            ViewData["leagues"] = new SelectList(applicationDb.Leagues, "Id", "Name");
            var match = applicationDb.Matches.Where(e => e.Id == Id).FirstOrDefault();
            return View(match);
        }
        [HttpPost]
        public IActionResult EditMatch(Match match)
        {
            ViewData["clubs"] = new SelectList(applicationDb.Clubs, "Id", "Name");
            ViewData["ServerId"] = new SelectList(applicationDb.serverNames, "Id", "Name");
            ViewData["leagues"] = new SelectList(applicationDb.Leagues, "Id", "Name");
            if (ModelState.IsValid)
            {
                applicationDb.Update(match);
                applicationDb.SaveChanges();
                return RedirectToAction("Matches","Home");
            }
                
            return View(match);
        }

        [HttpPost]
        public IActionResult AddMatch(Match match)
        {
            ViewData["clubs"] = new SelectList(applicationDb.Clubs, "Id", "Name");
            ViewData["ServerId"] = new SelectList(applicationDb.serverNames, "Id", "Name");
            ViewData["leagues"] = new SelectList(applicationDb.Leagues, "Id", "Name");
            if (ModelState.IsValid)
            {
                applicationDb.Add(match);
                applicationDb.SaveChanges();
                return View();
            }
            return View(match);
        }

        public IActionResult AddServerName()
        {
            ViewData["clubs"] = new SelectList(applicationDb.Clubs, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddServerName(ServerName serverName)
        {
            
            if (ModelState.IsValid)
            {
                applicationDb.serverNames.Add(serverName);
                applicationDb.SaveChanges();
                return View();
            }
            return View(serverName);
        }
        public IActionResult AddServerLink()
        {
            ViewData["ServerId"] = new SelectList(applicationDb.serverNames, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult AddServerLink(ServerLink serverLink)
        {
            ViewData["ServerId"] = new SelectList(applicationDb.serverNames, "Id", "Name");
            if (ModelState.IsValid)
            {
                applicationDb.serverLinks.Add(serverLink);
                applicationDb.SaveChanges();
                return View();
            }
            return View(serverLink);
        }

    }
}
