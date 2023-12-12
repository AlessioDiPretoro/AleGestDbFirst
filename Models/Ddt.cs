using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class Ddt
    {
        public Ddt()
        {
            DdtDetails = new HashSet<DdtDetail>();
        }

        public int Id { get; set; }
        public int DocumentTypeId { get; set; }
        public int SupplierId { get; set; }
        public DateTime Date { get; set; }
        public string Number { get; set; } = null!;
        public string Note { get; set; } = null!;
        public int Discount { get; set; }

        public virtual DocumentType DocumentType { get; set; } = null!;
        public virtual ICollection<DdtDetail> DdtDetails { get; set; }
    }
}
