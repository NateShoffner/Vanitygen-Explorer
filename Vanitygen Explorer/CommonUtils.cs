namespace Vanitygen_Explorer
{
    internal class CommonUtils
    {
        public static string TruncateVersion(string version, bool enforceDecimal = true)
        {
            while (version.EndsWith("0") || version.EndsWith("."))
            {
                version = version.Remove(version.Length - 1, 1);
            }

            if (enforceDecimal && !version.Contains("."))
            {
                version = string.Format("{0}.0", version);
            }

            return version;
        }
    }
}