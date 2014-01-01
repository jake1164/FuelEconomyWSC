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
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NotJustMaple.WebService.FuelEconomy.API.Models
{
    /// <summary>
    /// Implementation of http://www.fueleconomy.gov/feg/ws/index.shtml#vehicle
    /// </summary>
    [GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [SerializableAttribute]
    [DebuggerStepThroughAttribute]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    [XmlRoot("vehicle")]
    public class VehicleModel
    {
        private string atvTypeField;

        private string barrels08Field;

        private string barrelsA08Field;

        private string charge120Field;

        private string charge240Field;

        private string city08Field;

        private string city08UField;

        private string cityA08Field;

        private string cityA08UField;

        private string cityCDField;

        private string cityEField;

        private string cityUFField;

        private string co2Field;

        private string co2AField;

        private string co2TailpipeAGpmField;

        private string co2TailpipeGpmField;

        private string comb08Field;

        private string comb08UField;

        private string combA08Field;

        private string combA08UField;

        private string combEField;

        private string combinedCDField;

        private string combinedUFField;

        private string cylindersField;

        private string displField;

        private string driveField;

        private string engIdField;

        private string eng_dscrField;

        private string evMotorField;

        private string feScoreField;

        private string fuelCost08Field;

        private string fuelCostA08Field;

        private string fuelTypeField;

        private string fuelType1Field;

        private string fuelType2Field;

        private string ghgScoreField;

        private string ghgScoreAField;

        private string guzzlerField;

        private string highway08Field;

        private string highway08UField;

        private string highwayA08Field;

        private string highwayA08UField;

        private string highwayCDField;

        private string highwayEField;

        private string highwayUFField;

        private string hlvField;

        private string hpvField;

        private string idField;

        private string lv2Field;

        private string lv4Field;

        private string makeField;

        private string mfrCodeField;

        private string modelField;

        private string mpgDataField;

        private string phevBlendedField;

        private string pv2Field;

        private string pv4Field;

        private string rangeAField;

        private string rangeCityAField;

        private string rangeHwyAField;

        private string trans_dscrField;

        private string tranyField;

        private string uCityField;

        private string uCityAField;

        private string uHighwayField;

        private string uHighwayAField;

        private string vClassField;

        private string yearField;

        private string youSaveSpendField;

        private NotJustMaple.WebService.FuelEconomy.API.Models.EmissionInfo.EmissionsInfo[][] _emissionsInfoListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string atvType
        {
            get { return this.atvTypeField; }
            set { this.atvTypeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string barrels08
        {
            get { return this.barrels08Field; }
            set { this.barrels08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string barrelsA08
        {
            get { return this.barrelsA08Field; }
            set { this.barrelsA08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string charge120
        {
            get { return this.charge120Field; }
            set { this.charge120Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string charge240
        {
            get { return this.charge240Field; }
            set { this.charge240Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string city08
        {
            get { return this.city08Field; }
            set { this.city08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string city08U
        {
            get { return this.city08UField; }
            set { this.city08UField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cityA08
        {
            get { return this.cityA08Field; }
            set { this.cityA08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cityA08U
        {
            get { return this.cityA08UField; }
            set { this.cityA08UField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cityCD
        {
            get { return this.cityCDField; }
            set { this.cityCDField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cityE
        {
            get { return this.cityEField; }
            set { this.cityEField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cityUF
        {
            get { return this.cityUFField; }
            set { this.cityUFField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string co2
        {
            get { return this.co2Field; }
            set { this.co2Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string co2A
        {
            get { return this.co2AField; }
            set { this.co2AField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string co2TailpipeAGpm
        {
            get { return this.co2TailpipeAGpmField; }
            set { this.co2TailpipeAGpmField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string co2TailpipeGpm
        {
            get { return this.co2TailpipeGpmField; }
            set { this.co2TailpipeGpmField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string comb08
        {
            get { return this.comb08Field; }
            set { this.comb08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string comb08U
        {
            get { return this.comb08UField; }
            set { this.comb08UField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string combA08
        {
            get { return this.combA08Field; }
            set { this.combA08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string combA08U
        {
            get { return this.combA08UField; }
            set { this.combA08UField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string combE
        {
            get { return this.combEField; }
            set { this.combEField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string combinedCD
        {
            get { return this.combinedCDField; }
            set { this.combinedCDField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string combinedUF
        {
            get { return this.combinedUFField; }
            set { this.combinedUFField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string cylinders
        {
            get { return this.cylindersField; }
            set { this.cylindersField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string displ
        {
            get { return this.displField; }
            set { this.displField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string drive
        {
            get { return this.driveField; }
            set { this.driveField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string engId
        {
            get { return this.engIdField; }
            set { this.engIdField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string eng_dscr
        {
            get { return this.eng_dscrField; }
            set { this.eng_dscrField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string evMotor
        {
            get { return this.evMotorField; }
            set { this.evMotorField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string feScore
        {
            get { return this.feScoreField; }
            set { this.feScoreField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fuelCost08
        {
            get { return this.fuelCost08Field; }
            set { this.fuelCost08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fuelCostA08
        {
            get { return this.fuelCostA08Field; }
            set { this.fuelCostA08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fuelType
        {
            get { return this.fuelTypeField; }
            set { this.fuelTypeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fuelType1
        {
            get { return this.fuelType1Field; }
            set { this.fuelType1Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fuelType2
        {
            get { return this.fuelType2Field; }
            set { this.fuelType2Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ghgScore
        {
            get { return this.ghgScoreField; }
            set { this.ghgScoreField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ghgScoreA
        {
            get { return this.ghgScoreAField; }
            set { this.ghgScoreAField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string guzzler
        {
            get { return this.guzzlerField; }
            set { this.guzzlerField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string highway08
        {
            get { return this.highway08Field; }
            set { this.highway08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string highway08U
        {
            get { return this.highway08UField; }
            set { this.highway08UField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string highwayA08
        {
            get { return this.highwayA08Field; }
            set { this.highwayA08Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string highwayA08U
        {
            get { return this.highwayA08UField; }
            set { this.highwayA08UField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string highwayCD
        {
            get { return this.highwayCDField; }
            set { this.highwayCDField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string highwayE
        {
            get { return this.highwayEField; }
            set { this.highwayEField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string highwayUF
        {
            get { return this.highwayUFField; }
            set { this.highwayUFField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string hlv
        {
            get { return this.hlvField; }
            set { this.hlvField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string hpv
        {
            get { return this.hpvField; }
            set { this.hpvField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lv2
        {
            get { return this.lv2Field; }
            set { this.lv2Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string lv4
        {
            get { return this.lv4Field; }
            set { this.lv4Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string make
        {
            get { return this.makeField; }
            set { this.makeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mfrCode
        {
            get { return this.mfrCodeField; }
            set { this.mfrCodeField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string model
        {
            get { return this.modelField; }
            set { this.modelField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mpgData
        {
            get { return this.mpgDataField; }
            set { this.mpgDataField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string phevBlended
        {
            get { return this.phevBlendedField; }
            set { this.phevBlendedField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string pv2
        {
            get { return this.pv2Field; }
            set { this.pv2Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string pv4
        {
            get { return this.pv4Field; }
            set { this.pv4Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rangeA
        {
            get { return this.rangeAField; }
            set { this.rangeAField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rangeCityA
        {
            get { return this.rangeCityAField; }
            set { this.rangeCityAField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rangeHwyA
        {
            get { return this.rangeHwyAField; }
            set { this.rangeHwyAField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string trans_dscr
        {
            get { return this.trans_dscrField; }
            set { this.trans_dscrField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string trany
        {
            get { return this.tranyField; }
            set { this.tranyField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UCity
        {
            get { return this.uCityField; }
            set { this.uCityField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UCityA
        {
            get { return this.uCityAField; }
            set { this.uCityAField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UHighway
        {
            get { return this.uHighwayField; }
            set { this.uHighwayField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string UHighwayA
        {
            get { return this.uHighwayAField; }
            set { this.uHighwayAField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string VClass
        {
            get { return this.vClassField; }
            set { this.vClassField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string year
        {
            get { return this.yearField; }
            set { this.yearField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string youSaveSpend
        {
            get { return this.youSaveSpendField; }
            set { this.youSaveSpendField = value; }
        }

        [XmlElement("sCharger")]
        private string Supercharger { get; set; }

        [XmlElement("tCharger")]
        private string Turbocharger { get; set; }

        /// <summary>
        /// Returns true if the vehicle is supercharged
        /// </summary>
        public bool Supercharged { get { return Supercharger != null && Supercharger == "S"; } }

        /// <summary>
        /// Returns true if the vehicle is supercharged
        /// </summary>
        public bool Turbocharged { get { return Turbocharger != null && Turbocharger == "T"; } }

        ///// <remarks/>
        //[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        //[System.Xml.Serialization.XmlArrayItemAttribute("emissionsInfo", typeof (EmissionsInfo),
        //    Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        //public EmissionsInfo[][] EmissionsInfoList
        //{
        //    get { return this._emissionsInfoListField; }
        //    set { this._emissionsInfoListField = value; }
        //}
    }
}