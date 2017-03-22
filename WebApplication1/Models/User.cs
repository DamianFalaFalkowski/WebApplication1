using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string full_name { get { return first_name + "" + last_name; } }
        public string hash_password { get; set; }
        public string email { get; set; }
    }

    //public class UserDBCtxt : DbContext
    //{
    //    public List<User> Users { get; set; }
    //}
}