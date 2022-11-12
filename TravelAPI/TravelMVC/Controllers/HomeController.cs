using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
      /*  [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            // extract only the fielname            
            var imageName = Path.GetFileName("./Images/Doremon.jpg");
            var imgsrc = Path.Combine(Server.MapPath("C:\\Users\\vaishnavi\\OneDrive\\Pictures"), imageName);
            string filepathToSave = "./images/" + imageName;
            file.SaveAs(imgsrc);
            ViewBag.ImagPath = filepathToSave;
            return View();
        }*/
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}