using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;

namespace Tickets
{
    public class Class1 : MarshalByRefObject
    {
        XmlDocument DocX;
         public void LoadTicket()
        {
            XmlDocument DocX = new XmlDocument();
            DocX.Load("Tickets.xml"); 
        }
        public ArrayList GetPrices()
         {
             ArrayList result = new ArrayList();
             result.Clear(); 
             XmlTextReader xTReader = new XmlTextReader("Tickets.xml");
             xTReader.WhitespaceHandling = WhitespaceHandling.None;


             XmlDocument xDoc = new XmlDocument();
             xDoc.Load(xTReader);
             XmlNodeList xNodeList =
             xDoc.DocumentElement.SelectNodes("/Tickets/Ticket/*");

             foreach (XmlNode xNode in xNodeList)
             {
                 if (xNode.NodeType == XmlNodeType.Element)
                 {
                     result.Add(xNode.Name + " = " + xNode.FirstChild.Value);
                 }
                 else
                 {
                     result.Add(xNode.NodeType.ToString() + ": " +
                     xNode.Name + " = " + xNode.Value);
                 }
             }
             return result;
         }
        public ArrayList GetSinglePrice(string location)
        {
            ArrayList result = new ArrayList();
            result.Clear();
            XmlTextReader xTReader = new XmlTextReader("Tickets.xml");
            xTReader.WhitespaceHandling = WhitespaceHandling.None;


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(xTReader);
            XmlNodeList xNodeList =
            xDoc.DocumentElement.SelectNodes("/Tickets/Ticket/" + location);

            foreach (XmlNode xNode in xNodeList)
            {
                if (xNode.NodeType == XmlNodeType.Element)
                {
                    result.Add(xNode.Name + " = " + xNode.FirstChild.Value);
                }
                else
                {
                    result.Add(xNode.NodeType.ToString() + ": " +
                    xNode.Name + " = " + xNode.Value);
                }
            }
            return result;

           
        }
  
    }
}
