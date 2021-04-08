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
            /*
            Teacher teacher1 = new Teacher { Id = "fnahiuf312u32hf", Email = "teacher1@mail.com" };
            Teacher teacher2 = new Teacher { Id = "oiehfuiasf12", Email = "teacher2@mail.com" };
            Teacher teacher3 = new Teacher { Id = "afagtygyyt124", Email = "teacher3@mail.com" };
            Teacher teacher4 = new Teacher { Id = "7441234afd4a6f", Email = "teacher4@mail.com" };
            ctx.Teachers.AddRange(teacher1, teacher2, teacher3, teacher4);
            ctx.SaveChanges();
            */
        }
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var teachers = from s in ctx.Teachers
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                teachers = teachers.Where(s => s.Email.Contains(searchString)
                                       || s.Name.Contains(searchString));
            }
            
            //сортування, дописати
            switch (sortOrder)
            {   
                case "name":
                    teachers = teachers.OrderBy(s => s.Name);
                    break;
                default:
                    teachers = teachers.OrderBy(s => s.Email);
                    break;
            }
            

            int pageSize = 3;
            return View(await PaginatedList<Teacher>.CreateAsync(teachers.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [Route(CRUD)]
        public IActionResult Get()
        {
            var model = ctx.Teachers.ToArray();
            return Ok(model);
        }
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        /*
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 3;   // кількість елементів на сторінці

            IQueryable<Teacher> source = ctx.Teachers;
            //IEnumerable<Teacher> source = ctx.Teachers.ToArray();
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PaginatedList pageViewModel = new PaginatedList(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Teachers = items
            };
            return View(viewModel);
        }
        */




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
