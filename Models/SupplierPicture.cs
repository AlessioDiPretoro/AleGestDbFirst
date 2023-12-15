using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class SupplierPicture
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public int SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; } = null!;
    }
}
