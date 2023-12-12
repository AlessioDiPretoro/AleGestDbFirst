using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class SupplierContactRel
    {
        public int Id { get; set; }
        public int SupplierContactId { get; set; }
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } = null!;
        public virtual SupplierContact SupplierContact { get; set; } = null!;
    }
}
