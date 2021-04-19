using CheckItControl.Data;
using CheckItControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CheckItControl.Controllers
{
    public class GroupController : BaseController<Group>
    {
        private static string[] searchable = new string[] { "Title" };

        public GroupController(AppDbContext ctx) : base(searchable)
        {
            base.ctx = ctx;
            items = ctx.Groups;
        }
        public IActionResult getTitle(int id)
        {
            string title = ctx.Groups.FirstOrDefault(o => o.Id == id).Title;
            return Ok(title);
        }
    }
}
