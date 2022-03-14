
using GpProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnMatch.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GpProject.Controllers.Api
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly ApplicationDbContext DbContext;
        public MatchController(ApplicationDbContext applicationDbContext)
        {
            DbContext = applicationDbContext;
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMatch(string id)
        {
            var report = DbContext.Matches.Where(report => report.Id == Int32.Parse(id)).First();
            DbContext.Remove(report);
            DbContext.SaveChanges();
            return Ok();
        }
    }
}
