using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication221220.Models
{
    public class Diary
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string content { get; set; }

        public Diary()
        {
            id = string.Empty;
            date = DateTime.Now;
            title = string.Empty;
            content = string.Empty;
        }
        public Diary(string _id, DateTime _date, string _title, string _content)
        {
            id = _id;
            date = _date;
            title = _title;
            content = _content;
        }
    }

}