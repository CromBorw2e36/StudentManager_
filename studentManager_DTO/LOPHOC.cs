namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOPHOC")]
    public partial class LOPHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPHOC()
        {
            PHANCONG = new HashSet<PHANCONG>();
            TINHTRANGPHONG = new HashSet<TINHTRANGPHONG>();
        }

        [Key]
        [StringLength(5)]
        [Display(ShortName = "Company", Name = "Company Name")]
        public string MALOPHOC { get; set; }

        [StringLength(5)]
        public string MAMON { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKT { get; set; }

        public bool? DAKHOA { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TINHTRANGPHONG> TINHTRANGPHONG { get; set; }
    }
}
