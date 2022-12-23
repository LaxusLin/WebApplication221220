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
        private MydbContext db = new MydbContext();

        public ActionResult Index()
        {
            var result = db.Diarys.First();

            Diary diary = new Diary();
            diary.id = result.id;
            diary.title = result.title;
            diary.content = result.content;
            diary.date = result.date;

            return View(diary);
        }
        public ActionResult keep()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(Diary model)
        {
            Diary diary = new Diary();
            diary.id = model.id;
            diary.title = model.title;
            diary.content = model.content;
            diary.date = DateTime.Now;

            db.Diarys.Add(diary);
            db.SaveChanges();

            return View(diary);

        }
    }
}