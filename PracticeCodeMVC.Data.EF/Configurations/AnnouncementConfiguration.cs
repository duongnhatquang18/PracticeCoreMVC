using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
             builder.ToTable("Announcements");
             builder.Property(x => x.Title).HasMaxLength(250).IsRequired();
             builder.Property(x => x.Content).HasMaxLength(250);
             builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();

        }
    }
}
