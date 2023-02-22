namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANG_KI
    {
        [Key]
        [StringLength(5)]
        public string MALOPHOC { get; set; }

        [Required]
        [StringLength(5)]
        public string MABL { get; set; }

        public virtual BIEN_LAI BIEN_LAI { get; set; }
    }
}
