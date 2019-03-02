using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class FooterConfiguration : IEntityTypeConfiguration<Footer>
    {
        public void Configure(EntityTypeBuilder<Footer> builder)
        {
            builder.ToTable("Footers");
            builder.Property(x => x.Content).IsRequired();
        }
    }
}
