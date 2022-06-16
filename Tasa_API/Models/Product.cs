namespace Tasa_API.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Sales = new HashSet<Sale>();
        }

        [Key]
        public long Prod_Code { get; set; }

        [Required]
        [StringLength(250)]
        public string Prod_Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Prod_Category { get; set; }

        [StringLength(250)]
        public string Prod_Size { get; set; }

        public double Prod_Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
