using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WAD.Models;

namespace WAD.Context
{
    public class ExamContext : DbContext
    {
        public DbSet<Exam> Exams { get; set; } 
    }
}