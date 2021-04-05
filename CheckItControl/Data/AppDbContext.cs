using CheckItControl.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckItControl.Data
{
    public class AppDbContext : IdentityDbContext<Teacher>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
    }
}
