using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Gig
    {
        public int id { get; set; }
        public string name { get; set; }
        public int seats { get; set; }
        public DateTime gig_date { get; set; }
        public string description { get; set; }
        public bool passed { get { return DateTime.Now > gig_date; } }
    }

    //public class GigDBCtxt : DbContext
    //{
    //    public DbSet<Gig> Gigs { get; set; }
    //}
}