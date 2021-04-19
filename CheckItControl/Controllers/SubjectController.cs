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
    public class SubjectController : BaseController<Subject>
    {
        public SubjectController(AppDbContext ctx)
        {
            base.ctx = ctx;
            items = ctx.Subjects;
        }
    }
}
