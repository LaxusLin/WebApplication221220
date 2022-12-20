using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication221220.Models;

namespace WebApplication221220.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Diary diary = new Diary("1", DateTime.Now, "第一篇日記", "第一篇日記的內容");

            return View(diary);
        }
        public ActionResult keep()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(Diary model)
        {
            string id = model.id;
            string title = model.title;
            string content = model.content;

            Diary diary = new Diary(id, DateTime.Now, title, content);
            return View(diary);
        }
    }
}