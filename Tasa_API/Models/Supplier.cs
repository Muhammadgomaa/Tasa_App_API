namespace Tasa_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        [Key]
        public long Supp_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Supp_Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Supp_Phone { get; set; }
    }
}
