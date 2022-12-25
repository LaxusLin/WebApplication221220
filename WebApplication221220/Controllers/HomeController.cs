using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            var result = db.Diarys.ToList().OrderBy(item => item.date);
            return View(result);
        }
        public ActionResult Keep()
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

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diary diary = db.Diarys.Find(id);
            if (diary == null)
            {
                return HttpNotFound();
            }

            return View(diary);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "id,date,title, content")] Diary diary)
        {
            diary.date = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Entry(diary).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index", "Home", null);
            }
            return View(diary);
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diary diary = db.Diarys.Find(id);
            if (diary == null)
            {
                return HttpNotFound();
            }
            db.Diarys.Remove(diary);
            db.SaveChanges();

            return RedirectToAction("Index", "Home", null);
        }
    }
}