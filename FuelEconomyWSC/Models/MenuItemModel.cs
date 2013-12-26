using System.Xml.Serialization;

namespace NotJustMaple.WebService.FuelEconomy.API.Models
{
    [XmlRoot("menuItems")]
    public class MenuItemModel
    {
        [XmlElement("menuItem", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MenuItem[] Items;      
        
        public class MenuItem
        {
            [XmlElement("text")]
            public string Text { get; set; }

            [XmlElement("value")]
            public string Value { get; set; }
        }     
    }
 
}