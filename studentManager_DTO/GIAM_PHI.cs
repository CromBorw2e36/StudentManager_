namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIAM_PHI
    {
        [Key]
        [StringLength(1)]
        public string MAHOCVIEN { get; set; }

        [Required]
        [StringLength(5)]
        public string MADIEN { get; set; }

        public virtual DIEN_GIAM_PHI DIEN_GIAM_PHI { get; set; }
    }
}
