using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
//Jake Saylor, Corbin King, Peter Maddsen, Michael Jenkins
namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Email(string name, string email)
        {
            MailMessage myMessage = new MailMessage("BlowOutInstrumentRentals@gmail.com", email);
            myMessage.Subject = "BlowOut Musical Instrument Rentals";
            myMessage.Body = "Hello " + name + ",<br><br>Thank you for reaching out to us!<br><br>We rent out many kinds of instruments, what kind of rental questions can we help you with?<br><br>Warm regards,<br><br>BlowOut Rentals Team | 801-555-1212";
            myMessage.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential myCredential = new NetworkCredential("BlowOutInstrumentRentals@gmail.com", "403BlowOut");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = myCredential;
            smtp.Send(myMessage);
            ViewBag.Message = "Thank you " + name + ". We will send an email to " + email;

            return View();
        }
    }
}