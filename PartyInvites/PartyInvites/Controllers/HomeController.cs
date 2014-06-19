using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            DateTime dt = DateTime.Now;
            ViewBag.Greeting = dt.Hour > 12 ? "Good Evening Commisioner!" : "Morning You!";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email responses to party organizer.
                return View("Thanks",guestResponse);
            }
            else
            {
                // there is some validation error so return them to fix it
                return View();
            }
    
        }
    }
}
