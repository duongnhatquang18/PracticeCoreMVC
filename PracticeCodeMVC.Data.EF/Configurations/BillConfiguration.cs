using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using PracticeCodeMVC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
             builder.ToTable("Bills");
             builder.Property(x => x.CustomerName).HasMaxLength(256).IsRequired();
             builder.Property(x => x.CustomerAddress).HasMaxLength(256).IsRequired();
             builder.Property(x => x.CustomerPhone).HasMaxLength(50).IsRequired();
             builder.Property(x => x.CustomerMessage).HasMaxLength(256).IsRequired();
             builder.Property(x => x.Status).HasDefaultValue<Enums.Status>(Status.Active);

             builder.HasOne(x => x.User)
                    .WithMany(y => y.Bills)
                    .HasForeignKey(x => x.CustomerId);
        }
    }
}
