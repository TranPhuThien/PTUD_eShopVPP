using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.Utilities.Exceptions
{
    public class EShopVPPException : Exception
    {
        public EShopVPPException()
        {
        }

        public EShopVPPException(string message)
            : base(message)
        {
        }

        public EShopVPPException(string message, Exception inner)
            : base(message, inner)
        {
        }


    }
}
