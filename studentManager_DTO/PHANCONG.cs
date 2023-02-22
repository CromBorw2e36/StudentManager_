namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANCONG")]
    public partial class PHANCONG
    {
        [Key]
        [StringLength(5)]
        public string MAGIAOVIEN { get; set; }

        [Required]
        [StringLength(5)]
        public string MACAHOC { get; set; }

        [StringLength(5)]
        public string MALOPHOC { get; set; }

        public virtual CA_HOC CA_HOC { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }
    }
}
