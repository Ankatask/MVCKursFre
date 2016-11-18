using Day2Demo2.Data;
using Day2Demo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2Demo2.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;

        public HomeController()
        {
            _repo = Repository.GetRepo;
        }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            //Visa alla bokningar
            return View(_repo.GetBookings());
        }

        //Visa en specifik bokning
        public ViewResult Booking(int id)
        {
            return View(_repo.GetBookingById(id));
        }

        //Lägg till en bokning

        //Ta bort en bokning
        public ActionResult Remove(int id)
        {
            _repo.RemoveBookingById(id);
            return RedirectToAction("Index");
        }

        //Redigera en bokning
    }
}