using GeoApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GeoApplication.Controllers
{
    public class GeoController : Controller
    {
        public ActionResult PropertyDetails()
        {
            var listdata = new PropertyViewModel();

            return View(listdata);
        }

        private static List<Property> GetDetails()
        {
            return new List<Property>()
            {
                new Property(){ Number="50000", Name="Meadow View", Surname="Karatoprak"},
                new Property(){ Number="35000", Name="The Beeches", Surname="Chand"},
                new Property(){ Number="56000", Name="The Old School House", Surname="Ersoy"},
                new Property(){ Number="45000", Name="The Bungalow", Surname="Gold"},
             };
        }

        [HttpGet]
        public JsonResult GetDetailsByPrefix(string prefix)
        {
            var list = GetDetails();
            var customers = list.Where(x => x.Name.ToUpper().Contains(prefix.ToUpper())).ToList();
            var listdata = new PropertyViewModel();
            listdata.Properties = customers;
            listdata.Search = prefix;
            return Json(listdata, JsonRequestBehavior.AllowGet);
        }
    }
}