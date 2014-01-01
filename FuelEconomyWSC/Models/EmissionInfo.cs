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
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NotJustMaple.WebService.FuelEconomy.API.Models
{
    public class EmissionInfo
    {
        public enum SmartwayCertifcation
        {
            NotCertified = -1,
            Smartway = 1,
            SmartwayElite = 2
        }

        [GeneratedCode("xsd", "2.0.50727.3038")]
        [Serializable]
        [DebuggerStepThrough]
        [DesignerCategory("code")]
        [XmlTypeAttribute(AnonymousType = true)]
        public class EmissionsInfo
        {
            /// <summary>
            /// engine family ID
            /// </summary>
            [XmlElementAttribute(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("efid")]
            public string EngineFamilyId { get; set; }

            /// <summary>
            /// vehicle record ID (links emission data to the vehicle record)
            /// </summary>
            [XmlElement(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("id")]
            public int VehicleRecordId { get; set; }

            /// <summary>
            /// EPA sales area code
            /// TODO: Convert this an automatic definition lookup
            /// </summary>
            [XmlElement(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("salesArea")]
            public int SalesArea { get; set; }

            /// <summary>
            /// EPA 1-10 smog rating for fuelType1
            /// </summary>
            [XmlElement(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("score")]
            public string FuelType1Score { get; set; }

            /// <summary>
            /// /// EPA 1-10 smog rating for fuelType2
            /// </summary>
            [XmlElement(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("scoreAlt")]
            public string FuelType2Score { get; set; }

            /// <summary>
            /// EPA SmartWay Certification
            /// </summary>
            [XmlElement(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("smartwayScore")]
            public SmartwayCertifcation SmartwayCertification { get; set; }

            /// <summary>
            /// Vehicle Emission Standard Code
            /// TODO: Convert this an automatic definition lookup
            /// </summary>
            [XmlElement(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("standard")]
            public string Standard { get; set; }

            /// <summary>
            /// Vehicle Emission Standard
            /// </summary>
            [Obsolete("Consider using Standard to get both the id and value")]
            [XmlElement(Form = XmlSchemaForm.Unqualified)]
            [XmlElement("stdText")]
            public string StandardText { get; set; }
        }
    }
}