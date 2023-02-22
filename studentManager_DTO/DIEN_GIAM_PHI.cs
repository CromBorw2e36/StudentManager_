namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIEN_GIAM_PHI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIEN_GIAM_PHI()
        {
            GIAM_PHI = new HashSet<GIAM_PHI>();
        }

        [Key]
        [StringLength(5)]
        public string MADIEN { get; set; }

        [Required]
        [StringLength(100)]
        public string TENDIEN { get; set; }

        [Required]
        [StringLength(100)]
        public string MUCGIAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAM_PHI> GIAM_PHI { get; set; }
    }
}
