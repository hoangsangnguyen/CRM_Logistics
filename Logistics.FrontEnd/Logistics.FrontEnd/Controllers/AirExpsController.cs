using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Logistics.FrontEnd.Models;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Logistics.FrontEnd.Controllers
{
    public class AirExpsController : Controller
    {
        static HttpClient client = new HttpClient();

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
        public async Task<ActionResult> AddEdit(Guid id )
        {
            AirExpDto model;

            if(id == Guid.Empty)
            {
                model = new Models.AirExpDto();
            } else
            {
                string url = "https://localhost:44395/airexps/" + id;
                AirExpDto airExp =  await GetAirExpsAsync(url);
                model = airExp;
            }
            return View(model);
        }

        static async Task<AirExpDto> GetAirExpsAsync(string path)
        {
            string airExpStr = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                airExpStr = await response.Content.ReadAsStringAsync();
            }
            AirExpDto airExp = JsonConvert.DeserializeObject<AirExpDto>(airExpStr);
            Console.WriteLine(airExp);

            return airExp;
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