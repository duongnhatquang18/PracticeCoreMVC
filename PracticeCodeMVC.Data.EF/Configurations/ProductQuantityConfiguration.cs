using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class ProductQuantityConfiguration : IEntityTypeConfiguration<ProductQuantity>
    {  
        public void Configure(EntityTypeBuilder<ProductQuantity> builder)
        {
            builder.ToTable("ProductQuantities");
            builder.HasOne(x => x.Product)
                   .WithMany(y => y.ProductQuantities)
                   .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Size)
                   .WithOne(y => y.ProductQuantity)
                   .HasForeignKey<ProductQuantity>(x => x.SizeId);
            builder.HasOne(x => x.Color)
                   .WithOne(y => y.ProductQuantity)
                   .HasForeignKey<ProductQuantity>(x => x.ColorId);
        }
    }
}
