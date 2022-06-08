using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExceptionHandling.Controllers
{


    public class SecondController : BaseController
    {
        // GET: Second
        public ActionResult Index()
        {
            int i = 0;
            int num = 10;
            i = num / i;
            return View();
        }

        // GET: Second/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Second/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Second/Create
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

        // GET: Second/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Second/Edit/5
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

        // GET: Second/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Second/Delete/5
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
