using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class DdtDetail
    {
        public int Id { get; set; }
        public int DdtId { get; set; }
        public int ProductId { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public int? Discount { get; set; }
        public string? Note { get; set; }

        public virtual Ddt Ddt { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
