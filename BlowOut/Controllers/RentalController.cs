using BlowOut.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class RentalController : Controller
    {
        public static Instrament newInst = new Instrament();
        // GET: Rental
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Clarinet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Clarinet(FormCollection form)
        {

            if (form["new"] == "New")
            {

                ViewBag.Price = 70;
                ViewBag.InstCond = "NEW";
            }
            else
            {
                ViewBag.Price = 50;
                ViewBag.InstCond = "USED";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Flute()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Flute(FormCollection form)
        {
            if(form["new"] == "New")
            {

                ViewBag.Price = 40;
                ViewBag.InstCond = "NEW";
            }
            else
            {
                ViewBag.Price = 25;
                ViewBag.InstCond = "USED";
            }

            return View();
        }
        [HttpGet]
        public ActionResult Saxophone()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Saxophone(FormCollection form)
        {
            if (form["new"] == "New")
            {

                ViewBag.Price = 42;
                ViewBag.InstCond = "NEW";
            }
            else
            {
                ViewBag.Price = 30;
                ViewBag.InstCond = "USED";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Trombone()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Trombone(FormCollection form)
        {
            if (form["new"] == "New")
            {

                ViewBag.Price = 60;
                ViewBag.InstCond = "NEW";
            }
            else
            {
                ViewBag.Price = 35;
                ViewBag.InstCond = "USED";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Trumpet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Trumpet(FormCollection form)
        {
            if (form["new"] == "New")
            {

                ViewBag.Price = 55;
                ViewBag.InstCond = "NEW";
            }
            else
            {
                ViewBag.Price = 25;
                ViewBag.InstCond = "USED";
            }
            return View();
        }

        [HttpGet]
        public ActionResult Tuba()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Tuba(FormCollection form)
        {
            if (form["new"] == "New")
            {

                ViewBag.Price = 70;
                ViewBag.InstCond = "NEW";
            }
            else
            {
                ViewBag.Price = 50;
                ViewBag.InstCond = "USED";
            }
            return View();
        }
    }
}