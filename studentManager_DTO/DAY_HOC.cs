namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAY_HOC
    {
        [StringLength(5)]
        public string MAMON { get; set; }

        [StringLength(5)]
        public string MAGIAOVIEN { get; set; }

        [Key]
        [StringLength(10)]
        public string MADAYHOC { get; set; }
    }
}
