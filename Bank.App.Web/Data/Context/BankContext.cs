using Bank.App.Web.Data.Configurations;
using Bank.App.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bank.App.Web.Data.Context
{
    public class BankContext : DbContext
    {
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public BankContext(DbContextOptions<BankContext> options) : base(options) 
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            base.OnModelCreating(modelBuilder); 
        }
    }

}