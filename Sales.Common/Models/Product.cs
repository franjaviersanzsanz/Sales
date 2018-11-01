

namespace Sales.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Desdcription { get; set; }
        public Decimal Price { get; set; }
        public Boolean IsAvailable { get; set; }
        public DateTime PublishOn { get; set; }
    }

    public class keyAttribute : Attribute
    {
    }
}
