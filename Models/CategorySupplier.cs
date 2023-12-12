using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class CategorySupplier
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Supplier Supplier { get; set; } = null!;
    }
}
