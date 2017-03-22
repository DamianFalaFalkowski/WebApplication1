using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class Booking
    {
        public int id { get; set; }
        public int gig_id { get; set; }
        public int user_id { get; set; }
    }

    //public class BookingDBCtxt : DbContext
    //{
    //    public List<Booking> Bookings { get; set; }
    //}
}