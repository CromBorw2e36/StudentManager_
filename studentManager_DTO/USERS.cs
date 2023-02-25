namespace studentManager_DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [StringLength(10)]
        public string id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(500)]
        public string password { get; set; }

        [StringLength(254)]
        public string email { get; set; }

        [StringLength(254)]
        public string ho { get; set; }

        [StringLength(254)]
        public string ten { get; set; }

        public bool? permission { get; set; }
    }
}
