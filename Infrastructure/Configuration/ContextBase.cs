using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration;

public class ContextBase : IdentityDbContext<ApplicationUser>
{
    public ContextBase(DbContextOptions options) : base(options)
    {
    }

    public DbSet<FinancialSystem> FinancialSystem { get; set; }
    public DbSet<FinancialSystemUser> FinancialSystemUser { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Expense> Expense { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(x => x.Id);
        
        base.OnModelCreating(builder);
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(GetConnectionString());
            
            base.OnConfiguring(optionsBuilder);
        }
    }

    public string GetConnectionString()
    {
        return "";
    }
}