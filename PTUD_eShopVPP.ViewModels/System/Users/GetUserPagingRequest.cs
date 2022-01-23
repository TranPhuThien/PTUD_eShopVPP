using PTUD_eShopVPP.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.ViewModels.System.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
