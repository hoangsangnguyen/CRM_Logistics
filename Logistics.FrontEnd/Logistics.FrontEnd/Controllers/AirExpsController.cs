using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Logistics.FrontEnd.Controllers
{
    public class AirExpsController : Controller
    {
        // GET: AirExps
        public ActionResult Index()
        {
            return View();
        }

        // GET: AirExps/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AirExps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AirExp/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AirExp/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AirExp/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AirExp/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AirExp/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}