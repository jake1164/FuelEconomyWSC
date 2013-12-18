using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace NotJustMaple.WebService.FuelEconomy.Models
{
    public class MenuItemModel
    {
        [XmlRoot("menuItems")]
        public class MenuItems
        {
            [XmlElement("menuItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
            public MenuItem[] Items;
        }

        public class MenuItem
        {
            [XmlElement("text")]
            public string Text { get; set; }

            [XmlElement("value")]
            public string Value { get; set; }
        }
    }
}