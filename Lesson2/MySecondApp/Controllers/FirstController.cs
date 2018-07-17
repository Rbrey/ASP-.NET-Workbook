using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySecondApp.Models;

namespace MySecondApp.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public IActionResult Index()
        {
            var model = new MyModel();
            model.myFirstName = "Robert";
            model.mySurname = "Brey";
            model.luckyNum = 21;            
            return View(model);
        }

        // GET: First/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: First/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: First/Create
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

        // GET: First/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: First/Edit/5
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

        // GET: First/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: First/Delete/5
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