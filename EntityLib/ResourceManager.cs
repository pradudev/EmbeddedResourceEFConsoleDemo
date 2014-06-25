using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;
using System.Configuration;
using System.Xml.Linq;

namespace EntityLib
{
    public class ResourceManager
    {
        public static string ConnectionString { 
            get {
                    string strFileName = "EntityLib.Settings.Config";
                    var assembly = Assembly.GetExecutingAssembly();
                    var stream = assembly.GetManifestResourceStream(strFileName);

                    var doc = XDocument.Load(stream);

                    var conn = doc.Element("settings").Element("connectionString").Attribute("value").Value; 

                    return conn;
            } 
        }
    }
}
