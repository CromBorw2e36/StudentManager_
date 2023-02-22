namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BIEN_LAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BIEN_LAI()
        {
            DANG_KI = new HashSet<DANG_KI>();
            HOC_VIEN = new HashSet<HOC_VIEN>();
        }

        [Key]
        [StringLength(5)]
        public string MABL { get; set; }

        [Required]
        [StringLength(100)]
        public string NGAYBL { get; set; }

        [Required]
        [StringLength(200)]
        public string NOIDUNG { get; set; }

        public double? SOTIEN { get; set; }

        [Required]
        [StringLength(100)]
        public string BANGCHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANG_KI> DANG_KI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOC_VIEN> HOC_VIEN { get; set; }
    }
}
