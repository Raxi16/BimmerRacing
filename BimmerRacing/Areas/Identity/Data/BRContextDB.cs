using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BimmerRacing.Models;

namespace BimmerRacing.Areas.Identity.Data;

public class BRContextDB : IdentityDbContext<IdentityUser>
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
        new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
        new IdentityRole { Id = "2", Name = "Staff", NormalizedName = "STAFF" }
        );

        var harsher = new PasswordHasher<IdentityUser>();
        builder.Entity<IdentityUser>().HasData(

            new IdentityUser
            {
                Id = "1",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@bimmerracing.com",
                NormalizedEmail = "ADMIN@BIMMERRACING.COM",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Admin123@")
            },
            new IdentityUser
            {
                Id = "2",
                UserName = "Rafi",
                NormalizedUserName = "Rafi",
                Email = "ac119820@avcol.school.nz",
                NormalizedEmail = "AC119820@AVCOL.SCHOOL.NZ",
                EmailConfirmed = true,
                PasswordHash = harsher.HashPassword(null, "Staff123@")
            }

        );

        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = "1", UserId = "1" },
            new IdentityUserRole<string> { RoleId = "2", UserId = "2" }
        );

    }

    public DbSet<BimmerRacing.Models.Cart> Cart { get; set; } = default!;

public DbSet<BimmerRacing.Models.Category> Category { get; set; } = default!;

public DbSet<BimmerRacing.Models.Customer> Customer { get; set; } = default!;

public DbSet<BimmerRacing.Models.Order> Order { get; set; } = default!;

public DbSet<BimmerRacing.Models.Payment> Payment { get; set; } = default!;

public DbSet<BimmerRacing.Models.Product> Product { get; set; } = default!;
}
