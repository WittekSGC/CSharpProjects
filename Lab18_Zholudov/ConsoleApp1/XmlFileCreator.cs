using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace ConsoleApp1
{
    class XmlFileCreator
    {
        private static string XmlVersion = "1.0";
        private static string XmlCodeType = "utf-8";
        private XmlDocument xmlDocument;

        public XmlFileCreator()
        {
            CreateXML();
        }

        public void CreateXML()
        {
            xmlDocument = new XmlDocument();
            XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration(XmlVersion, XmlCodeType, null);

            xmlDocument.AppendChild(xmlDeclaration);
            XmlElement root = xmlDocument.CreateElement("root");
            xmlDocument.AppendChild(root);

            XmlElement metaInfo = xmlDocument.CreateElement("metaInfo");
            metaInfo.InnerText = "metaInfo text";
            root.AppendChild(metaInfo);
        }

        public void AddNodeInRoot(string nodeName)
        {
            XmlElement root = xmlDocument.DocumentElement;
            XmlElement newNode = xmlDocument.CreateElement(nodeName);
            root.AppendChild(newNode);
        }

        public void SaveXmlDoc(string docName)
        {
            FileStream file = new FileStream($"{docName}.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(file);
            xmlDocument.Save(writer);
        }

        public void AddNodeAttr(string nodeName, string nodeAttrName, string nodeAttrText)
        {
            XmlAttribute newAttr;// = xmlDocument.CreateAttribute(nodeAttrName);
            XmlNode resident;// = xmlDocument.SelectSingleNode($"//{nodeName}");
            XmlNodeList listNodes = xmlDocument.SelectNodes($"//{nodeName}");
            
            if (listNodes != null) 
            {
                for (int i = 0; i < listNodes.Count; i++)
                {
                    resident = listNodes.Item(i);
                    newAttr = xmlDocument.CreateAttribute(nodeAttrName);
                    newAttr.Value = nodeAttrText;
                    resident.Attributes.Append(newAttr);
                }
            }
        }
    }
}
