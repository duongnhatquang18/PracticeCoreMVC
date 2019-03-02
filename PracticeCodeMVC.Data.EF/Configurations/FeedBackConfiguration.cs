using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
             builder.ToTable("FeedBacks");
             builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
             builder.Property(x => x.Email).HasMaxLength(250);
             builder.Property(x => x.Message).HasMaxLength(500);
        }
    }
}
