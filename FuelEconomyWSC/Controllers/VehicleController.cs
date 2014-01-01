/********************************************************************************
### The MIT License (MIT)

### Copyright (c) 2013 Jason Jackson

### Permission is hereby granted, free of charge, to any person obtaining a copy of
### this software and associated documentation files (the "Software"), to deal in
### the Software without restriction, including without limitation the rights to
### use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
### the Software, and to permit persons to whom the Software is furnished to do so,
### subject to the following conditions:

### The above copyright notice and this permission notice shall be included in all
### copies or substantial portions of the Software.

### THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
### IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
### FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
### COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
### IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
### CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### This software is an adaptation of Parker Smith's FEWS C# project from github
### https://github.com/parkrrr/FEWS

*********************************************************************************/
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
    /// <summary>
    /// Class that will provide the Vehicle api that interfaces with the 
    /// FuelEconomy Web Services. More information:
    /// http://www.fueleconomy.gov/feg/ws/index.shtml
    /// </summary>
    public class VehicleController : ApiController
    {
        /// <summary>
        /// Base webservice prefix.
        /// </summary>
        private const String RootURI = "http://www.fueleconomy.gov/ws/rest/";

        /// <summary>
        ///  Returns a list of model years
        /// </summary>
        /// <returns>Json or xml String</returns>
        public MenuItemModel GetYears()
        {
            return Request<MenuItemModel>("vehicle/menu/year");
        }

        /// <summary>
        /// Return a list of makes for a particular year
        /// </summary>
        /// <param name="year">Model Year</param>
        /// <returns>Json or xml String</returns>
        public MenuItemModel GetMakes(Int32 year)
        {
            return Request<MenuItemModel>(String.Format("vehicle/menu/make?year={0}", year));
        }

        /// <summary>
        /// Return a list of models for a particular year and make
        /// </summary>
        /// <param name="year">Model Year</param>
        /// <param name="make">Manufacturer</param>
        /// <returns>Json or xml String</returns>
        public MenuItemModel GetModels(Int32 year, String make)
        {
            return Request<MenuItemModel>(String.Format("vehicle/menu/model?year={0}&make={1}", year, make));
        }

        /// <summary>
        ///  Return a list of model options and the associated vehicle ID for a particular year, make and model
        /// </summary>
        /// <param name="year">Model Year</param>
        /// <param name="make">Manufacturer</param>
        /// <param name="model">Automotive Model</param>
        /// <returns>Json or xml String</returns>
        public MenuItemModel GetOptions(Int32 year, String make, String model)
        {
            return Request<MenuItemModel>(String.Format("vehicle/menu/options?year={0}&make={1}&model={2}", year, make, model));
        }
        
        /// <summary>
        ///  Return a specific vehicle record
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Json or xml String</returns>
        public VehicleModel GetVehicle(Int32 id)
        {            
            return Request<VehicleModel>(String.Format("vehicle/{0}", id));
        }

        /// <summary>
        /// Method used to create the correct URI and return the correct class object
        /// </summary>
        /// <typeparam name="T">Class Type</typeparam>
        /// <param name="path">URI</param>
        /// <returns>Class Object</returns>
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
