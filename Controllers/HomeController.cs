using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace SmitWinkel.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OurTeam()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult NewPatient()
        {
            return View();
        }

        public ActionResult PatientForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatientForm(FormCollection collection)
        {
            try
            {

                //System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

                //message.From = new System.Net.Mail.MailAddress(WebConfigurationManager.AppSettings["from"]);
                //message.To.Add(new System.Net.Mail.MailAddress(WebConfigurationManager.AppSettings["to"]));

                //message.IsBodyHtml = true;
                //message.BodyEncoding = Encoding.UTF8;
                //message.Subject = "Appointment";
                //foreach (var key in collection.AllKeys)
                //{
                //    message.Body += collection.Get(key);
                //}

                //System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                //client.Credentials = new System.Net.NetworkCredential("pieter.roodt@gmail.com", "lolnoob101");
                //client.EnableSsl = true;
                //client.Send(message);

                ViewData["Message"] = SmitWinkel.Resources.Home.Success.Appointment.ToString();
                return View("Success");
            }
            catch (Exception ex)
            {
                ViewData["Message"] = SmitWinkel.Resources.Home.Success.Appointment.ToString();
                ViewData["Error"] = ex.ToString();
                return View("Error");
            }
        }

        public ActionResult Appointment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Appointment(FormCollection collection)
        {
            try
            {
                //System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();

                //message.From = new System.Net.Mail.MailAddress(WebConfigurationManager.AppSettings["from"]);
                //message.To.Add(new System.Net.Mail.MailAddress(WebConfigurationManager.AppSettings["to"]));

                //message.IsBodyHtml = true;
                //message.BodyEncoding = Encoding.UTF8;
                //message.Subject = "Appointment";
                //foreach (var key in collection.AllKeys)
                //{
                //    message.Body += collection.Get(key);
                //}

                //System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                //client.Credentials = new System.Net.NetworkCredential("pieter.roodt@gmail.com", "lolnoob101");
                //client.EnableSsl = true;
                //client.Send(message);

                ViewData["Message"] = SmitWinkel.Resources.Home.Success.Appointment.ToString();
                return View("Success");
            }
            catch (Exception ex)
            {
                ViewData["Message"] = SmitWinkel.Resources.Home.Success.Appointment.ToString();
                ViewData["Error"] = ex.ToString();
                return View("Error");
            }
            
        }
    }
}
