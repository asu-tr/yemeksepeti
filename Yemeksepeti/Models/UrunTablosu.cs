namespace Yemeksepeti.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UrunTablosu")]
    public partial class UrunTablosu
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string UserSurname { get; set; }

        [StringLength(25)]
        public string CategoryName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string Descriptionn { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Price { get; set; }
    }
}
