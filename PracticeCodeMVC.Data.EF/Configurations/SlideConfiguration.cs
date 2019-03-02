using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class SlideConfiguration : IEntityTypeConfiguration<Slide>
    {  
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.ToTable("Slides");
            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Url).HasMaxLength(250);
            builder.Property(x => x.GroupAlias).HasMaxLength(25).IsRequired();
        }
    }
}
