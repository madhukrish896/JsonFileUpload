using ImportJsonData_Demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MvcImportJSONData_Demo.Controllers
{
    public class HomeController : Controller
    {
        public object Assert { get; set; }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using (DBModel db = new DBModel())
            {
                List<customer1> customerList = db.customers1.ToList<customer1>();
                return Json(new { data = customerList }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase jsonFile)
        {
            using (DBModel db = new DBModel())
            {
                if (!jsonFile.FileName.EndsWith(".json"))
                {
                    ViewBag.Error = "Invalid file type(Only JSON file allowed)";
                }
                else
                {
                    jsonFile.SaveAs(Server.MapPath("~/FileUpload/" + Path.GetFileName(jsonFile.FileName)));
                    StreamReader streamReader = new StreamReader(Server.MapPath("~/FileUpload/" + Path.GetFileName(jsonFile.FileName)));
                    string data = streamReader.ReadToEnd();
                    List<customer1> customers1 = JsonConvert.DeserializeObject<List<customer1>>(data);
                    try
                    {
                        var item = db.customers1.SingleOrDefault();
                        item.id.ToString();
                        item.name.ToString();
                        db.customers1.Add(item);
                        db.SaveChanges();
                    }
                    catch
                    {
                        
                    }
                    



                    ViewBag.Success = "File uploaded Successfully..";
                }
            }
            return View("Index");
        }
    }
}
