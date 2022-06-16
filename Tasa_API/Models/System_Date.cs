namespace Tasa_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class System_Date
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(250)]
        public string Date { get; set; }

        [Key]
        [Column(Order = 1)]
        public double Total_Sales { get; set; }
    }
}
