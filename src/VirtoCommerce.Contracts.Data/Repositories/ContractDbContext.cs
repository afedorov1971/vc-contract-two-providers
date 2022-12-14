using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using VirtoCommerce.Contracts.Data.Models;

namespace VirtoCommerce.Contracts.Data.Repositories
{
    public class ContractDbContext : DbContextWithTriggers
    {
        private const int _maxLength128 = 128;

        public ContractDbContext(DbContextOptions<ContractDbContext> options)
            : base(options)
        {
        }

        protected ContractDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContractEntity>().ToTable("Contract").HasKey(x => x.Id);
            modelBuilder.Entity<ContractEntity>().Property(x => x.Id).HasMaxLength(_maxLength128).ValueGeneratedOnAdd();

            modelBuilder.Entity<ContractDynamicPropertyObjectValueEntity>().ToTable("ContractDynamicPropertyObjectValue").HasKey(x => x.Id);
            modelBuilder.Entity<ContractDynamicPropertyObjectValueEntity>().Property(x => x.Id).HasMaxLength(128).ValueGeneratedOnAdd();
            modelBuilder.Entity<ContractDynamicPropertyObjectValueEntity>().Property(x => x.DecimalValue).HasColumnType("decimal(18,5)");
            modelBuilder.Entity<ContractDynamicPropertyObjectValueEntity>().HasOne(p => p.Contract)
                .WithMany(s => s.DynamicPropertyObjectValues).HasForeignKey(k => k.ObjectId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ContractDynamicPropertyObjectValueEntity>().HasIndex(x => new { x.ObjectType, x.ObjectId })
                .IsUnique(false)
                .HasDatabaseName("IX_ObjectType_ObjectId");
        }
    }
}
