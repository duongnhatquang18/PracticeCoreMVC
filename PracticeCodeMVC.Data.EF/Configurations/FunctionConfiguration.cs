using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class FunctionConfiguration : IEntityTypeConfiguration<Function>
    {
        public void Configure(EntityTypeBuilder<Function> builder)
        {
            builder.ToTable("Functions");
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.URL).HasMaxLength(250).IsRequired();
            builder.Property(x => x.ParentId).HasMaxLength(128);
        }
    }
}
