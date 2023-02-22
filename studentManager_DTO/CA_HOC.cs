namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CA_HOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CA_HOC()
        {
            PHANCONG = new HashSet<PHANCONG>();
            TINHTRANGPHONG = new HashSet<TINHTRANGPHONG>();
        }

        [Key]
        [StringLength(5)]
        public string MACAHOC { get; set; }

        [Required]
        [StringLength(5)]
        public string BUOI { get; set; }

        [Required]
        [StringLength(50)]
        public string GIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHANCONG> PHANCONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TINHTRANGPHONG> TINHTRANGPHONG { get; set; }
    }
}
