using PTUD_eShopVPP.ViewModels.Common;
using PTUD_eShopVPP.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
