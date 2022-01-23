using PTUD_eShopVPP.ViewModels.Common;
using PTUD_eShopVPP.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.AdminApp.Services
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
