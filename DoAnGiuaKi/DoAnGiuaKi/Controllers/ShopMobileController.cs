using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKi.Controllers
{
    public class ShopMobileController : Controller
    {
        //
        // GET: /ShopMobile/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /ShopMobile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ShopMobile/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ShopMobile/Create
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

        //
        // GET: /ShopMobile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ShopMobile/Edit/5
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

        //
        // GET: /ShopMobile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ShopMobile/Delete/5
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
