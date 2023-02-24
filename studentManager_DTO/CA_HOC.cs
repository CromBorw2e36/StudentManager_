namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CA_HOC
    {
        [Key]
        [StringLength(5)]
        public string MACAHOC { get; set; }

        [Required]
        [StringLength(5)]
        public string BUOI { get; set; }

        [Required]
        [StringLength(50)]
        public string GIO { get; set; }
    }
}
