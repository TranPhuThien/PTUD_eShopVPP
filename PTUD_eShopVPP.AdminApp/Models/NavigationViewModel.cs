using PTUD_eShopVPP.ViewModels.System.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTUD_eShopVPP.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }

        public string CurrentLanguageId { get; set; }
    }
}
