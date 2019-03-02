using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System.Drawing;
using Color = PracticeCodeMVC.Data.Entities.Color;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors");
            builder.Property(x => x.Name).HasMaxLength(255);
            builder.Property(x => x.Code).HasMaxLength(255);
        }
    }
}