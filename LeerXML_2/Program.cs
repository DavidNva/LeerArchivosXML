using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeerXML_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "C:\\Users\\david\\OneDrive\\Documents\\Proyectos Programacion\\LeerXML_2\\LeerXML_2\\recursos\\xmlEjemplo.xml");
            UsingXmlReader(path);
        }//NombreC:\Users\david\OneDrive\Documents\Proyectos Programacion\LeerXML_2\LeerXML_2\recursos\
        private static void UsingXmlReader(string path)
        {
            XmlReader xmlReader = XmlReader.Create(path);

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "cfdi:Emisor"))
                {
                    if (xmlReader.HasAttributes)
                    {
                        Console.WriteLine(xmlReader.GetAttribute("Rfc") + ": " + xmlReader.GetAttribute("Nombre"));
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
