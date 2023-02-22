namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAY_HOC
    {
        [Key]
        [StringLength(5)]
        public string MAMON { get; set; }

        [Required]
        [StringLength(5)]
        public string MAGIAOVIEN { get; set; }

        public virtual GIAO_VIEN GIAO_VIEN { get; set; }
    }
}
