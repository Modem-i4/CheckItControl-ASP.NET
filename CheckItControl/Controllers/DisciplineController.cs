﻿using CheckItControl.Data;
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
    public class DisciplineController : BaseController<Quiz>
    {
        private static string[] searchable = new string[] { "Title" };

        public DisciplineController(AppDbContext ctx) : base(searchable)
        {
            base.ctx = ctx;
        }
    }
}
