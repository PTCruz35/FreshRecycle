using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalRecycleProject.Models;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace FinalRecycleProject.Controllers
{

   
    public class LoginController : Controller
    {
        private string DSN1 = System.Configuration.ConfigurationManager.AppSettings["connString"];

        public string DSNCode()
        {
            return DSN1;
        }
        // GET: Login
        // private DataModelContainer db = new DataModelContainer();
        public ActionResult NewUser()
        {

          

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult CreateOrUpdate(UserDetails user)
        {
            if(user !=null)
            {
               // SqlConnection con = new SqlConnection(this.DSNCode());
                
                // db.SaveChanges();
               


            }
            return View(user);



        }
    }
}