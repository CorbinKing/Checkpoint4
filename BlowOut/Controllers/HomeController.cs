//Authors: Corbin King, Jake Saylor, Mikey Jenkins, Peter Madsen

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlowOut.DAL;
using BlowOut.Models;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        //get db variable
        private InstrumentContext db = new InstrumentContext();
        
        //Landing page
        public ActionResult Index()
        {
            return View();
        }

        //About page
        public ActionResult About()
        {
            return View();
        }
        
        //Contact page
        public ActionResult Contact()
        {
            return View();
        }

        //Rentals page shows Instruments from DB
        public ActionResult Rentals()
        {
            return View(db.Instruments.ToList());
        }

        //Shows the create new client page
        [HttpGet]
        public ActionResult Create(int ID)
        {
            return View();
        }

        //Save changes to the client page and update the instrument object and instrument in the DB
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "clientID,clientFirstName,clientLastName,clientAddress,clientCity,clientState,clientZip,clientEmail,clientPhone")] Clients clients, int ID)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(clients);
                db.SaveChanges();
                // lookup instrument
                Instruments instruments = db.Instruments.Find(ID);
                //update instrument
                instruments.clientID = clients.clientID;
                db.Entry(instruments).State = EntityState.Modified;
                // save changes
                db.SaveChanges();

                return RedirectToAction("Summary", new { ClientID = clients.clientID, InstrumentID = instruments.instrumentID});
            }

            return View(clients);
        }

        //Show a summary page and show info that was added in the rental process
        public ActionResult Summary(int ClientID, int InstrumentID)
        {
            Clients client = db.Clients.Find(ClientID);
            Instruments instrument = db.Instruments.Find(InstrumentID);

            ViewBag.Client = client;
            ViewBag.Instrument = instrument;

            return View();
        }


    }
}