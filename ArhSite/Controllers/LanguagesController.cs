using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ArhSite.Controllers
{
    public class LanguagesController : Controller
    {
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Change(String strLanguageAbbrevation)
        {
            if (strLanguageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(strLanguageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(strLanguageAbbrevation);
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = strLanguageAbbrevation;
            Response.Cookies.Add(cookie);

            return View("Index");
        }
    }
}