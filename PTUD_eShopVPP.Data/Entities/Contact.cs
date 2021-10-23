using PTUD_eShopVPP.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.Data.Entities
{
    public class Contact
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
        public Status Status { set; get; }
    }
}
