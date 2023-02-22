namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHOA_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOA_HOC()
        {
            MONHOC = new HashSet<MONHOC>();
        }

        [Key]
        [StringLength(5)]
        public string MAKHOAHOC { get; set; }

        [Required]
        [StringLength(5)]
        public string TENKHOAHOC { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYKT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MONHOC> MONHOC { get; set; }
    }
}
