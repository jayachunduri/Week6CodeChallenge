using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [HttpGet]
        public ActionResult Index()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Index(Week6CodeChallenge.Models.ContactForm cf)
        {
            return PartialView("Greet");
        }

    }
}
