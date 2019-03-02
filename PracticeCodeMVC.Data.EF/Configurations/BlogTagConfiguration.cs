using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class BlogTagConfiguration : IEntityTypeConfiguration<BlogTag>
    {
        public void Configure(EntityTypeBuilder<BlogTag> builder)
        {
            builder.ToTable("BlogTags");

            builder.HasOne(x => x.Blog)
                   .WithMany(y => y.BlogTags)
                   .HasForeignKey(x => x.BlogId);

            builder.HasOne(x => x.Tag)
                   .WithMany(y => y.BlogTags)
                   .HasForeignKey(x => x.TagId);
        }
    }
}