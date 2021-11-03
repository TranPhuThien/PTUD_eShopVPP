using PTUD_eShopVPP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
