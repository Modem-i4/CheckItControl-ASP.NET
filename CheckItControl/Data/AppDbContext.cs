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
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Subject>().HasData(
                new Subject
                {
                    Id = 1,
                    Title = "Укр літ",
                    Description = ""
                },
                new Subject
                {
                    Id = 2,
                    Title = "Історія",
                    Description = ""
                },
                new Subject
                {
                    Id = 3,
                    Title = "Біологія",
                    Description = ""
                }
                );

            base.OnModelCreating(builder);
        }
    
    }
}
