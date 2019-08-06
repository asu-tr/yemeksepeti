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
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
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
        public virtual DbSet<ServedProducts> ServedProducts { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserTypes> UserTypes { get; set; }
        public virtual DbSet<WorkingHours> WorkingHours { get; set; }
        public virtual DbSet<MenuTablosu> MenuTablosu { get; set; }
        public virtual DbSet<Sehirler> Sehirler { get; set; }
        public virtual DbSet<SiparisTablosu> SiparisTablosu { get; set; }
        public virtual DbSet<SiparisTablosu_Orderer> SiparisTablosu_Orderer { get; set; }
        public virtual DbSet<SiparisTablosu_Seller> SiparisTablosu_Seller { get; set; }
        public virtual DbSet<SunulanYemekler> SunulanYemekler { get; set; }
        public virtual DbSet<UrunTablosu> UrunTablosu { get; set; }
        public virtual DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        public virtual DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public virtual DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public virtual DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public virtual DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public virtual DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }
        public virtual DbSet<YorumTablosu> YorumTablosu { get; set; }
        public virtual DbSet<YorumTablosu_Orderer> YorumTablosu_Orderer { get; set; }
        public virtual DbSet<YorumTablosu_Seller> YorumTablosu_Seller { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArrivalTimes>()
                .HasMany(e => e.ArrivalTime)
                .WithRequired(e => e.ArrivalTimes)
                .HasForeignKey(e => e.ArrivalTimeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Paths)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Roles)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Users)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers)
                .WithRequired(e => e.aspnet_Paths);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_Users)
                .WithMany(e => e.aspnet_Roles)
                .Map(m => m.ToTable("aspnet_UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Profile)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventSequence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventOccurrence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Categories)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.MenuContent)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ServedProducts)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServedProducts>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

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
                .HasMany(e => e.ServedProducts)
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

            modelBuilder.Entity<MenuTablosu>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SunulanYemekler>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}
