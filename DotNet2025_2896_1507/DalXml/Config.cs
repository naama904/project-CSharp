
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Dal;

internal static class Config
{
    public const string dataConfigXml = @"..\xml\data-config.xml";
    public static  int ProductCode=>int.Parse(XmlTools.GetValueByName("ProductCode"));
    public static  int SaleCode => int.Parse(XmlTools.GetValueByName("SaleCode"));

    public static int productId
    {
        get
        {
            XElement xml = XElement.Load(dataConfigXml);
            int nextId = (int)xml.Element("ProductCode");
            xml.Element("ProductCode").SetValue((nextId + 1).ToString());
            xml.Save(dataConfigXml);
            return nextId;
        }
    }
    public static int saleId
    {
        get
        {
            XElement xml = XElement.Load(dataConfigXml);
            int nextId = (int)xml.Element("SaleCode");
            xml.Element("SaleCode").SetValue((nextId + 1).ToString());
            xml.Save(dataConfigXml);
            return nextId;
        }
    }

}



