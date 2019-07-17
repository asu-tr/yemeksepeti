namespace Yemeksepeti.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            MenuContent = new HashSet<MenuContent>();
            OrderInfo = new HashSet<OrderInfo>();
        }

        [Key]
        public int ProductID { get; set; }

        public int SellerID { get; set; }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string Descriptionn { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public virtual Categories Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MenuContent> MenuContent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInfo> OrderInfo { get; set; }

        public virtual Users Users { get; set; }
    }
}
