using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class SupplierNote
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Body { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? AllarmDate { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } = null!;
    }
}
