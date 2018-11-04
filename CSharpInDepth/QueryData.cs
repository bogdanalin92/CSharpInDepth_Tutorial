using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpInDepth
{
    public class QueryData
    {
        internal static void QueryXML()
        {
            try
            {
                XDocument xdoc = XDocument.Load("xmlDoc.xml");
                if (xdoc != null)
                {
                    var filtered = from p in xdoc.Descendants("Product")
                                   join s in xdoc.Descendants("Supplier")
                                   on (int)p.Attribute("SupplierID") equals (int)s.Attribute("SupplierID")
                                   where (decimal)p.Attribute("Price") > 10
                                   orderby (string)s.Attribute("Name")
                                   select new
                                   {
                                       SupplierName = (string)s.Attribute("Name"),
                                       ProductName = (string)p.Attribute("Name")
                                   };

                }
            }
            catch (SystemException sept) { Console.WriteLine(sept.Message); }
        }
    }
}
