using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using PTUD_eShopVPP.ViewModels.Common;
using PTUD_eShopVPP.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.AdminApp.Services
{
    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
    {
        public LanguageApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageVm>>>("/api/languages");
        }
    }
}
