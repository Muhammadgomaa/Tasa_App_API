namespace Tasa_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        [Key]
        public long Trans_ID { get; set; }

        public long Invo_Num { get; set; }

        public long Cus_ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Cus_Name { get; set; }

        public long Prod_Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Prod_Name { get; set; }

        public long Quantity { get; set; }

        public double Price { get; set; }

        [Required]
        [StringLength(250)]
        public string Date { get; set; }

        [Required]
        [StringLength(250)]
        public string Time { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
