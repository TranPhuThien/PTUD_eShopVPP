using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PTUD_eShopVPP.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PTUD_eShopVPP.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).HasMaxLength(200);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Details).HasMaxLength(500);
            builder.Property(x => x.Quantity).HasDefaultValue(0);
            builder.Property(x => x.SeoAlias).HasMaxLength(200);
            builder.Property(x => x.Stock).HasDefaultValue(0);
            builder.Property(x => x.ViewCount).HasDefaultValue(0);
        }
    }
}
