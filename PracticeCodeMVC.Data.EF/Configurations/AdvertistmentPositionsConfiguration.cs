using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class AdvertistmentPositionsConfiguration : IEntityTypeConfiguration<AdvertisementPosition>
    {
        public void Configure(EntityTypeBuilder<AdvertisementPosition> builder)
        {
            builder.ToTable("AdvertisementPositions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PageId).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(250);

            builder.HasOne(x => x.AdvertistmentPage)
                   .WithMany(y => y.AdvertistmentPositions)
                   .HasForeignKey(x => x.PageId);
        }
    }
}