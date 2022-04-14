using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTL03MVCDB.Controllers
{
    public class PhoneController : Controller
    {
        Models.ContextDB db = new Models.ContextDB();
        // GET: Phone
        public ActionResult Index()
        {
            Models.Phone[] phones = db.Phones.ToArray<Models.Phone>();
            ViewBag.Phones = phones;
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]

        public ActionResult AddConfirm(string Press, string Name, string PNumber)
        {
            if (Press.Equals("OK"))
            {
                if (Name != null && !Name.Trim().Equals("") && PNumber != null)
                {
                    db.Phones.Add(new Models.Phone { Name = Name, PNumber = PNumber });
                    db.SaveChanges();
                }
                else return RedirectToAction("Add");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Del()
        {
            Models.Phone[] s = db.Phones.ToArray<Models.Phone>();
            ViewBag.phones = s;
            return View();
        }

        // POST: Student/Delete/5


        public ActionResult DelConfirm(int? ID)
        {
            if (ID != null)
            {
                Models.Phone s = db.Phones.Find((int)ID);
                if (s != null)
                {
                    db.Phones.Remove(s);
                    db.SaveChanges();
                }
                else return RedirectToAction("Del");

            }
            else return RedirectToAction("Del");
            return RedirectToAction("Index");
        }

        public ActionResult Upd()
        {
            Models.Phone[] s = db.Phones.ToArray<Models.Phone>();
            ViewBag.phones = s;
            return View();

        }
        public ActionResult UpdForm(int? ID)
        {
            if (ID != null)
            {
                Models.Phone s = db.Phones.Find((int)ID);
                if (s != null)
                {
                    ViewBag.phones = s;
                }
                else return RedirectToAction("Upd");

            }
            else return RedirectToAction("Upd");
            return View();
        }
        public ActionResult UpdConfirm(string Press, int? ID, string Name, string PNumber)
        {
            if (Press.Equals("OK"))
            {
                if (ID != null && Name != null && !Name.Trim().Equals("") && PNumber != null)
                {
                    Models.Phone s = db.Phones.Find(ID);
                    if (s != null)
                    {
                        s.Name = Name;
                        s.PNumber = PNumber;
                        db.SaveChanges();
                    }
                    else RedirectToAction("UpdForm");
                }
                else return RedirectToAction("UpdForm");

            }
            return RedirectToAction("Index");

        }
    }
}