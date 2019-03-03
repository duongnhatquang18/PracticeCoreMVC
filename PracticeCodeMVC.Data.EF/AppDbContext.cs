using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using PracticeCodeMVC.Data.EF.Configurations;
using PracticeCodeMVC.Data.Entities;
using PracticeCodeMVC.Data.Interfaces;
using System;
using System.Linq;

namespace PracticeCodeMVC.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Advertisement> advertisements { get; set;}
        public DbSet<AdvertisementPage> advertisementPages { get; set;}
        public DbSet<AdvertisementPosition> advertisementPositions { get; set;}
        public DbSet<Announcement> announcements { get; set;}
        public DbSet<AnnouncementUser> announcementUsers { get; set;}
        public DbSet<AppRole> appRoles { get; set;}
        public DbSet<AppUser> appUsers { get; set;}
        public DbSet<Bill> bills { get; set;}
        public DbSet<BillDetail> billDetails { get; set;}
        public DbSet<Blog> blogs { get; set;}
        public DbSet<BlogTag> blogTags { get; set;}
        public DbSet<Color> colors { get; set;}
        public DbSet<Contact> contacts { get; set;}
        public DbSet<FeedBack> feedBacks { get; set;}
        public DbSet<Footer> footers { get; set;}
        public DbSet<Function> functions { get; set;}
        public DbSet<Language> languages { get; set;}
        public DbSet<Page> pages { get; set;}
        public DbSet<Permissions> permissions { get; set;}
        public DbSet<ProductCategory> productCategories { get; set;}
        public DbSet<Product> products { get; set;}
        public DbSet<ProductImage> productImages { get; set;}
        public DbSet<ProductQuantity> productQuantities { get; set;}
        public DbSet<Size> sizes { get; set;}
        public DbSet<Slide> slides { get; set;}
        public DbSet<SystemConfig> systemConfigs { get; set;}
        public DbSet<Tag> tags { get; set;}
        public DbSet<WholePrice> wholePrices { get; set;}
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity Config

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims").HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });

            #endregion Identity Config

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

            //base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changedOrAddedItem.DateCreated = DateTime.Now;
                    }
                    changedOrAddedItem.DateModifined = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = "Server=.\\sqlexpress;Database=TeduCoreApp;Trusted_Connection=True;MultipleActiveResultSets=true";
            builder.UseSqlServer(connectionString);
            return new AppDbContext(builder.Options);
        }
    }
}