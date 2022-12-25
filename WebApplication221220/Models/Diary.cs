using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication221220.Models
{
    public class Diary
    {
        [Key]
        [Display(Name = "ID")]
        public string id { get; set; }

        [Required]
        [Display(Name = "時間")]
        public DateTime date { get; set; }

        [Required]
        [Display(Name = "標題")]
        public string title { get; set; }

        [Display(Name = "內容")]
        public string content { get; set; }

        //public Diary()
        //{
        //    id = string.Empty;
        //    date = DateTime.Now;
        //    title = string.Empty;
        //    content = string.Empty;
        //}
        //public Diary(string _id, DateTime _date, string _title, string _content)
        //{
        //    id = _id;
        //    date = _date;
        //    title = _title;
        //    content = _content;
        //}
    }

}