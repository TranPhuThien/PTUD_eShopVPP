using PTUD_eShopVPP.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.ViewModels.Catalog.Products.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
