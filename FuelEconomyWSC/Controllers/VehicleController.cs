using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using NotJustMaple.WebService.FuelEconomy.Models;

namespace NotJustMaple.WebService.FuelEconomy.Controllers
{
    public class VehicleController : Controller
    {
        private const String RootURI = "http://www.fueleconomy.gov/ws/rest/";
        //
        // GET: /Vecicle/

        public ActionResult Index()
        {
            return View();
        }

        public MenuItemModel GetYears()
        {
            return Request<MenuItemModel>("vehicle/menu/year");
        }


        public new T Request<T>(string path)
        {
            Uri uri = new Uri(new Uri(RootURI), path);

            WebClient wc = new WebClient();
            using (TextReader reader = new StringReader(wc.DownloadString(uri)))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}
