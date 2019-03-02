using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class WholePriceConfiguration : IEntityTypeConfiguration<WholePrice>
    {
        public void Configure(EntityTypeBuilder<WholePrice> builder)
        {
            builder.ToTable("WholePrices");
            builder.HasOne(x => x.Product)
                                        .WithOne(y => y.WholePrice)
                                        .HasForeignKey<WholePrice>(x => x.ProductId);
        }
    }
}
