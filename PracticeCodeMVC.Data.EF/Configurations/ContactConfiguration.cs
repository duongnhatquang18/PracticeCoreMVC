using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
             builder.ToTable("ContactDetails");
             builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
             builder.Property(x => x.Phone).HasMaxLength(50);
             builder.Property(x => x.Email).HasMaxLength(250);
             builder.Property(x => x.Name).HasMaxLength(250);
        }
    }
}
