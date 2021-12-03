using PTUD_eShopVPP.ViewModels.Common;
using PTUD_eShopVPP.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);

        Task<ApiResult<bool>> Register(RegisterRequest request);

        Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request);

        Task<ApiResult<UserVm>> GetById(Guid id);

        Task<ApiResult<bool>> Delete(Guid id);
    }
}
