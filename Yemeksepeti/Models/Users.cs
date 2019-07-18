namespace Yemeksepeti.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            ArrivalTime = new HashSet<ArrivalTime>();
            Comments = new HashSet<Comments>();
            Comments1 = new HashSet<Comments>();
            Menus = new HashSet<Menus>();
            MinOrderAmounts = new HashSet<MinOrderAmounts>();
            Orders = new HashSet<Orders>();
            Orders1 = new HashSet<Orders>();
            ServedProducts = new HashSet<ServedProducts>();
            WorkingHours = new HashSet<WorkingHours>();
        }

        [Key]
        public int UserID { get; set; }

        public int UserType { get; set; }

        [Required]
        [StringLength(40)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(25)]
        public string UserPassword { get; set; }

        [Required]
        [StringLength(30)]
        public string UserName { get; set; }

        [Required]
        [StringLength(20)]
        public string UserSurname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UserDateofBirth { get; set; }

        [StringLength(100)]
        public string UserAddress { get; set; }

        [Required]
        [StringLength(15)]
        public string UserCity { get; set; }

        [Required]
        [StringLength(20)]
        public string UserDistrict { get; set; }

        public int? UserLocationID { get; set; }

        [StringLength(15)]
        public string UserTel { get; set; }

        [MaxLength(1)]
        public byte[] UserPhoto { get; set; }

        [StringLength(255)]
        public string UserPhotoPath { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArrivalTime> ArrivalTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments1 { get; set; }

        public virtual Locations Locations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menus> Menus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MinOrderAmounts> MinOrderAmounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServedProducts> ServedProducts { get; set; }

        public virtual UserTypes UserTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkingHours> WorkingHours { get; set; }
    }
}
