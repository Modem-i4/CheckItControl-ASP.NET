using CheckItControl.Classes;
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
    public class DisciplineController : BaseController<Discipline>
    {
        private static string[] searchable = new string[] { "Title", "Description" };
        public int groupId;

        public DisciplineController(AppDbContext ctx) : base(searchable)
        {
            base.ctx = ctx;
            items = ctx.Disciplines;
        }
        public IActionResult Group(int id)
        {
            groupId = id;
            return View();
        }
        /*
        public override bool Filter(Discipline entity, Filter filter)
        {
            var group = ctx.Groups.Include(o => o.Disciplines).First(o => o.Id == 1);
            //var disciplines = groups.First(o => o.Id == 1).Disciplines;
            return group.Disciplines.Contains(entity);
        }*/
    }
}
