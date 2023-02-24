namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIAO_VIEN
    {
        [Key]
        [StringLength(5)]
        public string MAGIAOVIEN { get; set; }

        [StringLength(254)]
        public string HOGIAOVIEN { get; set; }

        [StringLength(254)]
        public string TENGIAOVIEN { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(254)]
        public string DIACHI { get; set; }
    }
}
