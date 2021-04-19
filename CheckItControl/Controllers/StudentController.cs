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
    public class StudentController : BaseController<Student>
    {
        private static string[] searchable = new string[] { "Name" };

        public StudentController(AppDbContext ctx) : base(searchable)
        {
            base.ctx = ctx;
            items = ctx.Students;
        }
        public IActionResult Group()
        {
            return View();
        }
    }
}
