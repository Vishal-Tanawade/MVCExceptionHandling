using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandling.Controllers
{
    [HandleError] //For Attribute error handling , We don't required any try catch block or override any method
    public class NormalController : Controller
    {
        // GET: Normal
        public ActionResult Index()
        {
            int i = 0;
            int num = 10;
            i = num / i;
            return View();
        }

        // GET: Normal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Normal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Normal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Normal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Normal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Normal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Normal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
