using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebApplication3.Departaments
{
    public class UpdateXmlHelper
    {
        public void UpdateNotificationDetail(string laboratory, string pcid)
        {
            XDocument xDocument = XDocument.Load("wwwroot/NotifiedDepartment.xml");
            XElement lab = xDocument.Element("Laboratory");
            XElement elementFinance = lab.Element(laboratory);
            if (elementFinance == null)
            {
                lab.Add(new XElement(laboratory,
                           new XElement("PCid", pcid)));
            }
            else
            {
                elementFinance.Add(new XElement("PCid", pcid));
            }
            xDocument.Save("wwwroot/NotifiedDepartment.xml");
        }
    }
}
