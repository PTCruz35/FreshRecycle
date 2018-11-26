using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalRecycleProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalRecycleProject.Controllers.Tests
{
    [TestClass()]
    public class RequestsControllerTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            RequestsController req = new RequestsController();
            Request reqNew = new Request();
            reqNew.Address = "15 main st";
            reqNew.FirstName = "Mike";
            reqNew.LastName = "donovan";
            reqNew.PhoneNumber = "45454544";
            reqNew.City = "Troy";
            reqNew.State = "Ohio";
            

            var rsult = req.Create(reqNew);

        }
    }
}