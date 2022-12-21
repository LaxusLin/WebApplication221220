using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication221220.Models
{
    public class MydbContext : DbContext
    {
        public DbSet<Diary> Diarys { get; set; }
    }
}