namespace Yemeksepeti.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model_YS : DbContext
    {
        public Model_YS()
            : base("name=Model_YS")
        {
        }

        public virtual DbSet<ArrivalTime> ArrivalTime { get; set; }
        public virtual DbSet<ArrivalTimes> ArrivalTimes { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<MenuContent> MenuContent { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<MinOrderAmounts> MinOrderAmounts { get; set; }
        public virtual DbSet<OrderInfo> OrderInfo { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderStats> OrderStats { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserTypes> UserTypes { get; set; }
        public virtual DbSet<WorkingHours> WorkingHours { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArrivalTimes>()
                .HasMany(e => e.ArrivalTime)
                .WithRequired(e => e.ArrivalTimes)
                .HasForeignKey(e => e.ArrivalTimeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locations>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Locations>()
                .HasMany(e => e.ArrivalTime)
                .WithRequired(e => e.Locations)
                .HasForeignKey(e => e.OrdererLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locations>()
                .HasMany(e => e.MinOrderAmounts)
                .WithRequired(e => e.Locations)
                .HasForeignKey(e => e.OrdererLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Locations>()
                .HasMany(e => e.Users)
                .WithOptional(e => e.Locations)
                .HasForeignKey(e => e.UserLocationID);

            modelBuilder.Entity<Menus>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Menus>()
                .HasMany(e => e.MenuContent)
                .WithRequired(e => e.Menus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MinOrderAmounts>()
                .Property(e => e.MOA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrderInfo>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderInfo)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderStats>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.OrderStats)
                .HasForeignKey(e => e.OrderStatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.MenuContent)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserTel)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserPhotoPath)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.ArrivalTime)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.SellerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.OrdererID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Comments1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.SellerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Menus)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.SellerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.MinOrderAmounts)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.SellerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.OrdererID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.SellerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.SellerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.WorkingHours)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.SellerID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserTypes>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserTypes)
                .HasForeignKey(e => e.UserType)
                .WillCascadeOnDelete(false);
        }
    }
}
