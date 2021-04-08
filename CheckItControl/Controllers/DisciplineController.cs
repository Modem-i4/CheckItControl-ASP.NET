using CheckItControl.Data;
using CheckItControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CheckItControl.Controllers
{
    public class DisciplineController : Controller
    {
        private readonly AppDbContext ctx;
        private const string CRUD = "api/discipline";

        public DisciplineController(AppDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
        /*
        [Route(CRUD)]
        public IActionResult Get(int id)
        {
            //var model = ctx.Disciplines.Include(z => z.Groups).Where(o => o.Groups.Id == id).ToArray();
            //return Ok(model);
        }
        /*
        public ActionResult Create(string Title)
        {
            string user_id = User.FindFirstValue(ClaimTypes.NameIdentifier);
           
            .Create(new Discipline
            {
                Title = Title,
               
            });
            return Ok();
        }
        */



    }
}
