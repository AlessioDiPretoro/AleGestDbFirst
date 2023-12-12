using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class Category
    {
        public Category()
        {
            CategoryProducts = new HashSet<CategoryProduct>();
            CategorySuppliers = new HashSet<CategorySupplier>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
        public virtual ICollection<CategorySupplier> CategorySuppliers { get; set; }
    }
}
