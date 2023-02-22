namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIPHONG")]
    public partial class LOAIPHONG
    {
        [Key]
        [StringLength(5)]
        public string MALOAIPHONG { get; set; }

        [Required]
        [StringLength(20)]
        public string TENLOAIPHONG { get; set; }
    }
}
