using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class SizeConfiguration : IEntityTypeConfiguration<Size>
    {  
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.ToTable("Sizes");
            builder.Property(x => x.Name).HasMaxLength(250);
        }
    }
}
