using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class ProductSupplier
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
    }
}
