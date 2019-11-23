using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlowOut.Models;
using System.Net;
using System.Net.Mail;

namespace BlowOut.Controllers
{
    public class GmailController : Controller
    {
        // GET: Gmail
        public ActionResult Index()
        {
            return View();
        }

        // Post: Gmail
        [HttpPost]
        public ActionResult Index(Gmail model)
        {
            MailMessage myMessage = new MailMessage("BlowOutInstrumentRentals@gmail.com", model.Email);
            myMessage.Subject = "BlowOut Musical Instrument Rentals";
            myMessage.Body = "Hello " + model.Name + ",<br><br>Thank you for reaching out to us!<br><br>We rent out many kinds of instruments, what kind of rental questions can we help you with?<br><br>Warm regards,<br><br>BlowOut Rentals Team | 801-555-1212";
            myMessage.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential myCredential = new NetworkCredential("BlowOutInstrumentRentals@gmail.com", "403BlowOut");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = myCredential;
            smtp.Send(myMessage);
            ViewBag.Message = "Thank you " + model.Name + ". We will send an email to " + model.Email;

            return View("Thanks");
        }
    }
}