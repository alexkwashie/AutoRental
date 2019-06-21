using AutoRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoRental.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Random()
        {
            var car = new Car() { Name = "Audi" };

            return View(car); //car here to render it in on the wepage
        }
    }
}