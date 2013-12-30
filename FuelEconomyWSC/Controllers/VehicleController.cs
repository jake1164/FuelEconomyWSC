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
            return Request<MenuItemModel>("vehicle/menu/year");
        }

        public MenuItemModel GetMakes(Int32 year)
        {
            return Request<MenuItemModel>(String.Format("vehicle/menu/make?year={0}", year));
        }

        public MenuItemModel GetModels(Int32 year, String make)
        {
            return Request<MenuItemModel>(String.Format("vehicle/menu/model?year={0}&make={1}", year, make));
        }

        public MenuItemModel GetOptions(Int32 year, String make, String model)
        {
            return Request<MenuItemModel>(String.Format("vehicle/menu/options?year={0}&make={1}&model={2}", year, make, model));
        }
        
        public VehicleModel GetVehicle(Int32 id)
        {            
            return Request<VehicleModel>(String.Format("vehicle/{0}", id));
        }

        [System.Web.Http.NonAction]
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
