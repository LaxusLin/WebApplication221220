using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication221220.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string content { get; set; }
    }
}