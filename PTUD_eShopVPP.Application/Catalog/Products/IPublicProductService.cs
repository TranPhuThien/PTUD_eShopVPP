using PTUD_eShopVPP.Application.Catalog.Products.Dtos;
using PTUD_eShopVPP.Application.Catalog.Products.Dtos.Public;
using PTUD_eShopVPP.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
