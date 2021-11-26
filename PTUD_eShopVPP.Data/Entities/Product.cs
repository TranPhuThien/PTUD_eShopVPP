using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.Data.Entities
{
    public class Product
    {
        //ID, Name, Code, MetaTitle, Description, Image, Quantity, CategoryID, Detail, Warranty, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy, Status, TopHot
        public int Id { set; get; }
        public string Name { get; set; }
        public string Description { set; get; }
        public string Details { set; get; }
        public int Quantity { get; set; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DateCreated { set; get; }
        public string SeoAlias { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
