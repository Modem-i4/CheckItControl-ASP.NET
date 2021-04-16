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
    public class QuizController : BaseController<Quiz>
    {
        private static string[] searchable = new string[] { "Title", "Description" };

        public QuizController(AppDbContext ctx) : base(searchable)
        {
            base.ctx = ctx;
            items = ctx.Quizzes;
        }
    }
}
