using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticeCodeMVC.Data.EF.Configurations;
using PracticeCodeMVC.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCodeMVC.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Advertisement> advertisements;
        public DbSet<AdvertisementPage> advertisementPages;
        public DbSet<AdvertisementPosition> advertisementPositions;
        public DbSet<Announcement> announcements;
        public DbSet<AnnouncementUser> announcementUsers;
        public DbSet<AppRole> appRoles;
        public DbSet<AppUser> appUsers;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdvertisementConfiguration());
            builder.ApplyConfiguration(new AdvertisementPageConfiguration());
            builder.ApplyConfiguration(new AdvertistmentPositionsConfiguration());
            builder.ApplyConfiguration(new AnnouncementConfiguration());
            builder.ApplyConfiguration(new AnnouncementUserConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new AppUserConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
