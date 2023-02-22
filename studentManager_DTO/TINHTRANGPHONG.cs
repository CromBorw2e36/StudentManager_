namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TINHTRANGPHONG")]
    public partial class TINHTRANGPHONG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MALOPHOC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MACAHOC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string MAPHONG { get; set; }

        public virtual CA_HOC CA_HOC { get; set; }

        public virtual LOPHOC LOPHOC { get; set; }

        public virtual PHONGHOC PHONGHOC { get; set; }
    }
}
