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

        public DisciplineController(AppDbContext ctx) : base(searchable)
        {
            base.ctx = ctx;
            items = ctx.Disciplines;
        }
    }
}
