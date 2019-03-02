using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracticeCodeMVC.Data.EF.Configurations;
using PracticeCodeMVC.Data.Entities;
using PracticeCodeMVC.Data.Enums;
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
        public DbSet<Bill> bills;
        public DbSet<BillDetail> billDetails;
        public DbSet<Blog> blogs;
        public DbSet<BlogTag> blogTags;
        public DbSet<Color> colors;
        public DbSet<Contact> contacts;
        public DbSet<FeedBack> feedBacks;
        public DbSet<Footer> footer;
        public DbSet<Function> functions;
        public DbSet<Language> languages;
        public DbSet<Page> pages;
        public DbSet<Permissions> permissions;
        public DbSet<ProductCategory> productCategories;
        public DbSet<Product> products;
        public DbSet<ProductImage> productImages;
        public DbSet<ProductQuantity> productQuantities;
        public DbSet<Size> sizes;
        public DbSet<Slide> slides;
        public DbSet<SystemConfig> systemConfigs;
        public DbSet<Tag> tags;
        public DbSet<WholePrice> wholePrices;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdvertisementConfiguration());
            builder.ApplyConfiguration(new AdvertisementPageConfiguration());
            builder.ApplyConfiguration(new AdvertistmentPositionsConfiguration());
            builder.ApplyConfiguration(new AnnouncementConfiguration());
            builder.ApplyConfiguration(new AnnouncementUserConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new AppUserConfiguration());
            builder.ApplyConfiguration(new BillConfiguration());
            builder.ApplyConfiguration(new BillDetailConfiguration());
            builder.ApplyConfiguration(new BlogConfiguration());
            builder.ApplyConfiguration(new BlogTagConfiguration());
            builder.ApplyConfiguration(new ColorConfiguration());
            builder.ApplyConfiguration(new ContactConfiguration());
            builder.ApplyConfiguration(new FeedBackConfiguration());
            builder.ApplyConfiguration(new FooterConfiguration());
            builder.ApplyConfiguration(new FunctionConfiguration());
            builder.ApplyConfiguration(new LanguageConfiguration());
            builder.ApplyConfiguration(new PageConfiguration());
            builder.ApplyConfiguration(new PermissionsConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ProductCategoryConfiguration());
            builder.ApplyConfiguration(new ProductImageConfiguration());
            builder.ApplyConfiguration(new ProductQuantityConfiguration());
            builder.ApplyConfiguration(new ProductTagConfiguration());
            builder.ApplyConfiguration(new SizeConfiguration());
            builder.ApplyConfiguration(new SlideConfiguration());
            builder.ApplyConfiguration(new SystemConfigConfiguration());
            builder.ApplyConfiguration(new TagConfiguration());
            builder.ApplyConfiguration(new WholePriceConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
