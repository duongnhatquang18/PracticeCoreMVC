using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class SystemConfigConfiguration : IEntityTypeConfiguration<SystemConfig>
    {  
        public void Configure(EntityTypeBuilder<SystemConfig> builder)
        {
            builder.ToTable("SystemConfigs");
            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
        }
    }
}
