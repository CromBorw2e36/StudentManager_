namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIAO_VIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAO_VIEN()
        {
            DAY_HOC = new HashSet<DAY_HOC>();
        }

        [Key]
        [StringLength(5)]
        public string MAGIAOVIEN { get; set; }

        [Required]
        [StringLength(20)]
        public string HOGIAOVIEN { get; set; }

        [Required]
        [StringLength(20)]
        public string TENGIAOVIEN { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYSINH { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAY_HOC> DAY_HOC { get; set; }
    }
}
