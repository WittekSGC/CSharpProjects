using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlFileCreator xmlFileCreator = new XmlFileCreator();
            for (int i = 0; i < 5; i++)
            {
                xmlFileCreator.AddNodeInRoot("MyNode");
            }
            xmlFileCreator.AddNodeAttr("MyNode", "newAttribute", "niceCook");
            xmlFileCreator.SaveXmlDoc("MyNewName");
            Console.ReadKey();
        }
    }
}
