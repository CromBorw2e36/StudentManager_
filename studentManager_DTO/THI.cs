namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THI")]
    public partial class THI
    {
        [Key]
        [StringLength(5)]
        public string MAKITHI { get; set; }

        [Required]
        [StringLength(5)]
        public string MAHOCVIEN { get; set; }

        [Required]
        [StringLength(5)]
        public string MAPHONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYTHI { get; set; }

        public double KETQUA { get; set; }

        [Required]
        [StringLength(20)]
        public string XEPLOAI { get; set; }

        public virtual HOC_VIEN HOC_VIEN { get; set; }

        public virtual KITHI KITHI { get; set; }

        public virtual PHONGHOC PHONGHOC { get; set; }
    }
}
