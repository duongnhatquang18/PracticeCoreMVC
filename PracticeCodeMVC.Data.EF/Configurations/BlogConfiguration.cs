using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
             builder.ToTable("Blogs");
             builder.Property(x => x.Name).HasMaxLength(256).IsRequired();
             builder.Property(x => x.Image).HasMaxLength(256);
             builder.Property(x => x.SeoAlias).HasMaxLength(256);
             builder.Property(x => x.SeoDescription).HasMaxLength(256);
             builder.Property(x => x.SeoKeyWords).HasMaxLength(256);
             builder.Property(x => x.SeoPageTitle).HasMaxLength(256);
        }
    }
}
