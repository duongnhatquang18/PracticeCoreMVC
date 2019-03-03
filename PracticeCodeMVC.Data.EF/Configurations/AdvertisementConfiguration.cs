using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class AdvertisementConfiguration : IEntityTypeConfiguration<Advertisement>
    {
        public void Configure(EntityTypeBuilder<Advertisement> builder)
        {
            builder.ToTable("Advertisements");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(250);
            builder.Property(x => x.Image).HasMaxLength(250);
            builder.Property(x => x.Url).HasMaxLength(250);
            builder.Property(x => x.PositionId).IsRequired();

            builder.HasOne(x => x.AdvertistmentPosition)
                   .WithMany(y => y.Advertistments)
                   .HasForeignKey(x => x.PositionId);
        }
    }
}