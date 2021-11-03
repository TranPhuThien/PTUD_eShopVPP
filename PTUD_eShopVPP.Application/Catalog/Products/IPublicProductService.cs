using PTUD_eShopVPP.Application.Catalog.Products.Dtos;
using PTUD_eShopVPP.Application.Catalog.Products.Dtos.Public;
using PTUD_eShopVPP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        public PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
