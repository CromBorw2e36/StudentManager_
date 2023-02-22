namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KITHI")]
    public partial class KITHI
    {
        [Key]
        [StringLength(5)]
        public string MAKITHI { get; set; }

        [Required]
        [StringLength(30)]
        public string TENKITHI { get; set; }

        public virtual THI THI { get; set; }
    }
}
