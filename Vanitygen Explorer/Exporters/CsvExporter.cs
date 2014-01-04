#region

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

#endregion

namespace Vanitygen_Explorer.Exporters
{
    internal class CsvExporter : IVanitygenExporter
    {
        #region Implementation of IVanitygenExporter

        public string Name
        {
            get { return "CSV Document"; }
        }

        public string Extension
        {
            get { return ".csv"; }
        }

        public void Export(string fileName, IEnumerable<VanitygenResult> results)
        {
            var sb = new StringBuilder();
            sb.Append("Address,");
            sb.Append("Key");
            sb.AppendLine();

            foreach (var fields in results.Select(result => new List<string> {result.Address, result.Key}))
            {
                sb.AppendLine(string.Join(",", fields.ToArray()));
            }

            File.WriteAllText(fileName, sb.ToString());
        }

        #endregion
    }
}