#region

using System.Collections.Generic;

#endregion

namespace Vanitygen_Explorer.Exporters
{
    internal interface IVanitygenExporter
    {
        string Name { get; }
        string Extension { get; }
        void Export(string fileName, IEnumerable<VanitygenResult> results);
    }
}