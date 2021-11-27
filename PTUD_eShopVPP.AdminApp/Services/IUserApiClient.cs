using PTUD_eShopVPP.ViewModels.Common;
using PTUD_eShopVPP.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.AdminApp.Services
{
    public interface IUserApiClient
    {
        Task<string> Authenticate(LoginRequest request);

        Task<PagedResult<UserVm>> GetUsersPagings(GetUserPagingRequest request);
    }
}
