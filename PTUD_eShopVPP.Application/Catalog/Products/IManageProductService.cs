using Microsoft.AspNetCore.Http;
using PTUD_eShopVPP.ViewModels.Catalog.Products;
using PTUD_eShopVPP.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewCount(int productId);

        //Task<List<ProductViewModel>> GetAll();

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        // sau khi thêm product, có thễ thêm/sửa/xóa riêng ảnh
        Task<int> AddImage(int productId, List<FormFile> files);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImage(int productId);

        Task<ProductViewModel> GetById(int productId);
    }
}
