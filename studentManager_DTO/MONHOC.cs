namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONHOC()
        {
            LOPHOC = new HashSet<LOPHOC>();
        }

        [Key]
        [StringLength(5)]
        public string MAMON { get; set; }

        [Required]
        [StringLength(5)]
        public string MAKHOAHOC { get; set; }

        [Required]
        [StringLength(20)]
        public string TENMON { get; set; }

        public double HOCPHI { get; set; }

        public virtual KHOA_HOC KHOA_HOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOPHOC> LOPHOC { get; set; }
    }
}
