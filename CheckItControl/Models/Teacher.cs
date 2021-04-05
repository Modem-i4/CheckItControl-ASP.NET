using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CheckItControl.Models
{
    public class Teacher : IdentityUser, IPerson
    {
        public string Name { get; set; }
        List<Discipline> Disciplines { get; set; }
        List<Quiz> Quizzes { get; set; }
    }
}
