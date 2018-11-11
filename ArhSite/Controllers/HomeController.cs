using ArhSite.Models;
using ArhSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ArhSite.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "Your application description page.";

         return View();
      }

      [HttpPost]
      public ActionResult Contact(ContactViewModel model)
      {
         try {
            if (ModelState.IsValid) {
               EmailSender service = new EmailSender();
               service.SendContact(model.FullName, model.Email, model.PhoneNumber, model.Message);
               return View("Index");
            }
            ViewBag.Section = "contact"; //#contact         
            return View("Index", model);
         } catch (Exception ex) {
            throw ex;
         }
      }
   }
}