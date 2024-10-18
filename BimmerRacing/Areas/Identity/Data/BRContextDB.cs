using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BimmerRacing.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BimmerRacing.Areas.Identity.Data;

public class BRContextDB : IdentityDbContext<ApplicationUser>
{
    public BRContextDB(DbContextOptions<BRContextDB> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityUserLogin<string>>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
        });

        builder.Entity<IdentityRole>().HasData(
        new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" }
        );

        var harsher = new PasswordHasher<ApplicationUser>(); // Declare the harsher variable here
        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "1",
                FirstName = "Admin",
                LastName = "Rafi",
                UserName = "admin@bimmerracing.com",
                NormalizedUserName = "ADMIN@BIMMERRACING.COM",
                Email = "admin@bimmerracing.com",
                NormalizedEmail = "ADMIN@BIMMERRACING.COM",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Admin123")
            }
        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = "1", UserId = "1" }
        );

    }

    public DbSet<BimmerRacing.Models.Cart> Cart { get; set; } = default!;

public DbSet<BimmerRacing.Models.Category> Category { get; set; } = default!;

public DbSet<BimmerRacing.Models.Customer> Customer { get; set; } = default!;

public DbSet<BimmerRacing.Models.Order> Order { get; set; } = default!;

public DbSet<BimmerRacing.Models.Payment> Payment { get; set; } = default!;

public DbSet<BimmerRacing.Models.Product> Product { get; set; } = default!;

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)

        {
            builder.Property(u => u.FirstName).HasMaxLength(20);
            builder.Property(u => u.LastName).HasMaxLength(20);
        }
    }
}