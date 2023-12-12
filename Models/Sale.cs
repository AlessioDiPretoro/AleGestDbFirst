using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SaleDetails = new HashSet<SaleDetail>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string CheckOut { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Fidelity { get; set; } = null!;
        public string Extra { get; set; } = null!;
        public int Discount { get; set; }

        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
