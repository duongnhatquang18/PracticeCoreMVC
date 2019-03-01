using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class AdvertisementPageConfiguration : IEntityTypeConfiguration<AdvertisementPage>
    {
        public void Configure(EntityTypeBuilder<AdvertisementPage> builder)
        {
            builder.ToTable("AdvertisementPages");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(20);
        }
    }
}