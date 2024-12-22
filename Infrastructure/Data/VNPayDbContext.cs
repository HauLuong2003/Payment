using Domain.Enities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class VNPayDbContext : DbContext
    {
        public VNPayDbContext(DbContextOptions<VNPayDbContext> options) : base(options) { }
        public DbSet<Merchant> Merchant { get; set; } = null!;
        public DbSet<Payment> Payment { get; set; } = null!;
        public DbSet<PaymentDestination> PaymentDestination { get; set; }
        public DbSet<PaymentSignature> PaymentSignature { get; set; }
        public DbSet<PaymentTransaction> PaymentTransaction { get; set; }
        public DbSet<PaymentNotification> PaymentNotification { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentDestination>(entity =>
            {
                entity.HasOne(c => c.PaymentDestinations)
                        .WithMany(c => c.Destinations)
                        .HasForeignKey(c => c.ParentId).OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
