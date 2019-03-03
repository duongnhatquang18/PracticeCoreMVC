using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class AnnouncementUserConfiguration : IEntityTypeConfiguration<AnnouncementUser>
    {
        public void Configure(EntityTypeBuilder<AnnouncementUser> builder)
        {
            builder.ToTable("AnnouncementUsers");
            builder.Property(x => x.AnnouncementId).IsRequired();
            builder.Property(x => x.UserId).HasMaxLength(450).IsRequired();

            builder.HasOne(x => x.Announcement)
                   .WithMany(y => y.AnnouncementUsers)
                   .HasForeignKey(x => x.AnnouncementId);

        }
    }
}
