namespace Vanitygen_Explorer
{
    internal class VanitygenResult
    {
        public VanitygenResult(string pattern, string address, string key)
        {
            Pattern = pattern;
            Address = address;
            Key = key;
        }

        public string Pattern { get; private set; }
        public string Address { get; private set; }
        public string Key { get; private set; }
    }
}