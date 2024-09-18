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
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

public DbSet<BimmerRacing.Models.Cart> Cart { get; set; } = default!;

public DbSet<BimmerRacing.Models.Category> Category { get; set; } = default!;

public DbSet<BimmerRacing.Models.Customer> Customer { get; set; } = default!;

public DbSet<BimmerRacing.Models.Order> Order { get; set; } = default!;

public DbSet<BimmerRacing.Models.Payment> Payment { get; set; } = default!;

public DbSet<BimmerRacing.Models.Product> Product { get; set; } = default!;
}
