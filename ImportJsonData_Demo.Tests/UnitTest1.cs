using ImportJsonData_Demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using MvcImportJSONData_Demo.Controllers;
using ImportJsonData_Demo;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ImportJsonData_Demo.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void GetData()
        {
            
        }

    }
}

  
