﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalRecycleProject.Models
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode{ get; set; }
        public int PhoneNumber { get; set; }
        public string EmailId{ get; set; }
    }
}