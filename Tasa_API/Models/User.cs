namespace Tasa_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public long User_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string User_Name { get; set; }

        [Required]
        [StringLength(250)]
        public string User_Password { get; set; }
    }
}
