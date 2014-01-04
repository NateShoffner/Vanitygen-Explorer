#region

using System;

#endregion

namespace Vanitygen_Explorer
{
    internal class VanitygenUpdateEventArgs : EventArgs
    {
        public VanitygenUpdateEventArgs(string hashRate, long total)
        {
            HashRate = hashRate;
            Total = total;
        }

        public string HashRate { get; private set; }
        public long Total { get; private set; }
    }
}