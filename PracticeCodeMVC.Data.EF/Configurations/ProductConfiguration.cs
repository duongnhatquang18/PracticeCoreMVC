using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
            builder.Property(x => x.Image).HasMaxLength(255);
            builder.Property(x => x.Price).HasDefaultValue(0).IsRequired();
            builder.Property(x => x.OriginalPrice).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.Property(x => x.Tags).HasMaxLength(255);
            builder.Property(x => x.Unit).HasMaxLength(255);
            builder.Property(x => x.SeoAlias).HasMaxLength(255);
            builder.Property(x => x.SeoKeyWords).HasMaxLength(255);
            builder.Property(x => x.SeoDescription).HasMaxLength(255);
            builder.HasOne(x => x.ProductCategory)
                                     .WithMany(y => y.Products)
                                     .HasForeignKey(x => x.CategoryId);

        }
    }
}
