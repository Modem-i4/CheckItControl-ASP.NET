using CheckItControl.Classes;
using CheckItControl.Data;
using CheckItControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CheckItControl.Controllers
{
    public class BaseController<T> : Controller where T : class
    {
        protected AppDbContext ctx;
        protected DbSet<T> items;
        private List<PropertyInfo> searchable;
        public BaseController() { }
        public BaseController(string[] searchableStrings)
        {
            searchable = searchableStrings.Select(o => typeof(T).GetProperty(o)).ToList();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Get(int page, int perPage, string sortBy, string sortDirection, string search, List<Filter> filters)
        {
            search ??= "";
            var sortField = typeof(T).GetProperty(sortBy);
            bool check(object item)
            {
                foreach (PropertyInfo query in searchable)
                {
                    if (Convert.ToString(query.GetValue(item)).Contains(search))
                        return true;
                }
                return false;
            }

            object order(object item) => sortField.GetValue(item);

            var model = items.Where(check); 



            
            foreach (var filter in filters)
            {
                model = model.Where(o => Filter(o, filter));
            }

            if (sortDirection == "DESC")
                model = model.OrderByDescending(order);
            else
                model = model.OrderBy(order);
            //model = model.Skip((page - 1) * perPage).Take(perPage).ToArray();
            return Ok(model);
        }
        public IActionResult GetAll()
        {
            var model = items.ToList();
            return Ok(model);
        }
        public virtual bool Filter(T entity, Filter filter)
        {
            var filterProp = typeof(T).GetProperty(filter.Title);
            string value = Convert.ToString(filterProp.GetValue(entity));
            return value == filter.Value;
        }

        public IActionResult Add(T model)
        {
            items.Add(model);
            ctx.SaveChanges();
            return Ok();
        }

        public IActionResult Edit(T model)
        {
            int? id = (int?)typeof(T).GetProperty("Id").GetValue(model);
            var entity = items.Find(id);
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                var value = prop.GetValue(model);
                prop.SetValue(entity, value);
            }
            ctx.SaveChanges();
            return Ok();
        }
        public IActionResult Delete(int id)
        {
            var entity = items.Find(id);
            items.Remove(entity);
            ctx.SaveChanges();
            return Ok();
        }
    }
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