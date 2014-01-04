#region

using System;

#endregion

namespace Vanitygen_Explorer
{
    internal class AddressGeneratedEventArgs : EventArgs
    {
        public AddressGeneratedEventArgs(VanitygenResult result)
        {
            Result = result;
        }

        public VanitygenResult Result { get; private set; }
    }
}