using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class CategoryProduct
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
