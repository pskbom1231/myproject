using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace MyStore.Models
{
    public partial class MyStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(local)\SQLEXPRESS;Database=MyStore;User Id=sa;Password=tns12345s");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductName).HasMaxLength(100);
            });

            modelBuilder.Entity<amphur>(entity =>
            {
                entity.HasKey(e => e.AMPHUR_ID);

                entity.Property(e => e.AMPHUR_ID).ValueGeneratedNever();

                entity.Property(e => e.AMPHUR_CODE).HasMaxLength(4);

                entity.Property(e => e.AMPHUR_NAME).HasMaxLength(150);

                entity.HasOne(d => d.GEO).WithMany(p => p.amphur).HasForeignKey(d => d.GEO_ID);

                entity.HasOne(d => d.PROVINCE).WithMany(p => p.amphur).HasForeignKey(d => d.PROVINCE_ID).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<district>(entity =>
            {
                entity.HasKey(e => e.DISTRICT_ID);

                entity.Property(e => e.DISTRICT_ID).ValueGeneratedNever();

                entity.Property(e => e.DISTRICT_CODE).HasMaxLength(6);

                entity.Property(e => e.DISTRICT_NAME).HasMaxLength(150);

                entity.HasOne(d => d.AMPHUR).WithMany(p => p.district).HasForeignKey(d => d.AMPHUR_ID);

                entity.HasOne(d => d.GEO).WithMany(p => p.district).HasForeignKey(d => d.GEO_ID);

                entity.HasOne(d => d.PROVINCE).WithMany(p => p.district).HasForeignKey(d => d.PROVINCE_ID).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<geography>(entity =>
            {
                entity.HasKey(e => e.GEO_ID);

                entity.Property(e => e.GEO_ID).ValueGeneratedNever();

                entity.Property(e => e.GEO_NAME).HasMaxLength(255);
            });

            modelBuilder.Entity<person>(entity =>
            {
                entity.HasKey(e => e.Person_id);

                entity.Property(e => e.Person_id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(10);

                entity.Property(e => e.Alley).HasMaxLength(30);

                entity.Property(e => e.Confirm_password).HasMaxLength(20);

                entity.Property(e => e.Firstname).HasMaxLength(50);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Moo).HasMaxLength(2);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.Road).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(20);

                entity.Property(e => e.Village).HasMaxLength(50);

                entity.HasOne(d => d.AmphurNavigation).WithMany(p => p.person).HasForeignKey(d => d.Amphur).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.DistrictNavigation).WithMany(p => p.person).HasForeignKey(d => d.District).OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.ProvinceNavigation).WithMany(p => p.person).HasForeignKey(d => d.Province).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<province>(entity =>
            {
                entity.HasKey(e => e.PROVINCE_ID);

                entity.Property(e => e.PROVINCE_ID).ValueGeneratedNever();

                entity.Property(e => e.PROVINCE_CODE).HasMaxLength(2);

                entity.Property(e => e.PROVINCE_NAME).HasMaxLength(150);

                entity.HasOne(d => d.GEO).WithMany(p => p.province).HasForeignKey(d => d.GEO_ID);
            });
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<amphur> amphur { get; set; }
        public virtual DbSet<district> district { get; set; }
        public virtual DbSet<geography> geography { get; set; }
        public virtual DbSet<person> person { get; set; }
        public virtual DbSet<province> province { get; set; }

        // Unable to generate entity type for table 'dbo.sysdiagrams'. Please see the warning messages.
    }
}