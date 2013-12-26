using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Serialization;
using NotJustMaple.WebService.FuelEconomy.API.Models;

namespace NotJustMaple.WebService.FuelEconomy.API.Controllers
{
    public class VehicleController : ApiController
    {
        private const String RootURI = "http://www.fueleconomy.gov/ws/rest/";

        public MenuItemModel GetYears()
        {
            MenuItemModel years = Request<MenuItemModel>("vehicle/menu/year");
            return years;//.Items.ToList();
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
