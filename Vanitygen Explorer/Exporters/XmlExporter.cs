#region

using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

#endregion

namespace Vanitygen_Explorer.Exporters
{
    internal class XmlExporter : IVanitygenExporter
    {
        #region Implementation of IVanitygenExporter

        public string Name
        {
            get { return "Xml Document"; }
        }

        public string Extension
        {
            get { return ".xml"; }
        }

        public void Export(string fileName, IEnumerable<VanitygenResult> results)
        {
            var doc = new XDocument(new XElement("results",
                new XElement("results", results.Select(x =>
                    new XElement("result",
                        new XElement("address", x.Address),
                        new XElement("key", x.Key))))));
            doc.Save(fileName);
        }

        #endregion
    }
}