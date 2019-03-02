using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {

             builder.ToTable("BillDetails");

             builder.HasOne(x => x.Bill)
                    .WithMany(y => y.BillDetails)
                    .HasForeignKey(x => x.BillID);

             builder.HasOne(x => x.Product)
                    .WithOne(y => y.BillDetail)
                    .HasForeignKey<BillDetail>(x => x.ProductID);

             builder.HasOne(x => x.Color)
                    .WithOne(y => y.BillDetail)
                    .HasForeignKey<BillDetail>(x => x.ColorId);

             builder.HasOne(x => x.Size)
                    .WithOne(y => y.BillDetail)
                    .HasForeignKey<BillDetail>(x => x.SizeId);
        }
    }
}
