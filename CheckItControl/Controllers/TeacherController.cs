using CheckItControl.Data;
using CheckItControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CheckItControl.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext ctx;
        private const string CRUD = "api/teacher";

        public TeacherController(AppDbContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route(CRUD)]
        public IActionResult Get()
        {
            var model = ctx.Teachers.ToArray();
            return Ok(model);
        }
        /*[Route(CRUD)]
        [HttpPost]
        public IActionResult Post(Teacher model)
        {
            ctx.Teachers.Add(model);
            ctx.SaveChanges();
            return Ok(model);
        }
        [HttpPut]
        public IActionResult Put(Teacher model)
        {
            var Teacher = ctx.Teachers.Find(model.Id);
            Teacher.Name = model.Name;
            Teacher.Description = model.Description;
            ctx.SaveChanges();
            return Ok(model);
        }
        [Route(CRUD)]
        [HttpDelete]
        public IActionResult Delete(Teacher model)
        {
            var Teacher = ctx.Teachers.Find(model.Id);
            ctx.Teachers.Remove(Teacher);
            ctx.SaveChanges();
            return Ok(model);
        }*/
    }
}
