using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF.Configurations
{
    public class PermissionsConfiguration : IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
        {
            builder.ToTable("Permissions");
            builder.Property(x => x.RoleId).HasMaxLength(450).IsRequired();
            builder.Property(x => x.FunctionId).IsRequired();
            builder.HasOne(x => x.AppRole)
                   .WithOne(y => y.Permissions)
                   .HasForeignKey<Permissions>(x => x.RoleId);
            builder.HasOne(x => x.Function)
                   .WithOne(y => y.Permissions)
                   .HasForeignKey<Permissions>(x => x.FunctionId);
        }
    }
}
