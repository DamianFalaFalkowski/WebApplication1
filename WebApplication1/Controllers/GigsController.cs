using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GigsController : Controller
    {
        private MyDB database = new MyDB();

        // GET: Gigs
        public ActionResult Index()
        {
            return View(database.Gigs.ToList());                        
        }

        // GET: /Gigs/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: /Gigs/Show/id
        public ActionResult Show(int id)
        {
            Gig g = database.Gigs.Where(x => x.id == id).First();
            return View(g);
        }

        // GET: /Gigs/Edit/id
        public ActionResult Edit(int id)
        {
            Gig g = database.Gigs.Where(x => x.id == id).First();
            return View(g);
        }

        // POST: /Cars/Create
        [HttpPost]
        //przesyłane wraz z POST, zabezpiecza przed złośliwą podmianą danych
        [ValidateAntiForgeryToken]
        //tutaj sprzężamy nasze pola z formularza z polami z modelu
        public ActionResult Create([Bind(Include = "id,name,seats,gig_date,description,seat_price")] Gig gig)
        {
            //sprawdzamy czy wystąpił jakiś błąd, np. błędny typ danych w formualrzu
            if (ModelState.IsValid)
            {
                gig.seats_left = gig.seats;
                //dodanie koncertu
                database.Gigs.Add(gig);
                //zapsiane zmian
                database.SaveChanges();
                //przekierowanie do strony o akcji Index
                return RedirectToAction("Index");
            }
            //jeśli ModelState.IsValid wracamy z powrotem do formularza
            return View(gig);
        }

        
    }
}