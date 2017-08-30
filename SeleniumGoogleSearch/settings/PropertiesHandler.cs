using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;

namespace OrangeHrSelenium
{
    class PropertiesHandler
    {
        private const string myprofile = @"settings\Settings.xml";
        private Dictionary<string, string> myprops = null;

        private static PropertiesHandler instance;
        private PropertiesHandler() { }
        public static PropertiesHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PropertiesHandler();
                    instance.LoadProperties();
                }
                return instance;
            }
        }

        public string FindValue(string key)
        {
            return this.FindValue(key, this.myprops);
        }

        private string FindValue(string key, Dictionary<string, string> props)
        {
            foreach (string k in props.Keys)
            {
                if (key.Equals(k, StringComparison.InvariantCultureIgnoreCase))
                {
                    return props[key];
                }
            }
            return null;
        }

        private void LoadProperties()
        {
            if (myprops == null)
            {
                myprops = new Dictionary<string, string>();
                this.LoadProperties(myprofile, myprops);
            }
        }

        private void LoadProperties(string file, Dictionary<string, string> props)
        {
            if (!File.Exists(file))
            {
                Environment.Exit(0);
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(file);
            foreach (XmlNode c in doc.ChildNodes)
            {
                if (c.Name.Equals("Settings"))
                {
                    foreach (XmlNode n in c.ChildNodes)
                    {
                        if (n.Name.Equals("add",
                            StringComparison.InvariantCultureIgnoreCase))
                        {
                            props.Add(
                                n.Attributes["key"].Value,
                                n.Attributes["value"].Value);
                        }
                    }
                }
            }
        }

    }
}

