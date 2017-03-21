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
        private GigDBCtxt database = new GigDBCtxt();

        // GET: Gigs
        public ActionResult Index()
        {
            if (database.Gigs==null)
            {
                return View(new List<Gig>() { });
            }
            else
            {
                return View(database.Gigs.ToList());
            }            
        }
    }
}