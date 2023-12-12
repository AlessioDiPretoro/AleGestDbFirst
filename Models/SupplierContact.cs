using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class SupplierContact
    {
        public SupplierContact()
        {
            SupplierContactRels = new HashSet<SupplierContactRel>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string EmailPec { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Cell { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Cap { get; set; } = null!;
        public string Prov { get; set; } = null!;
        public string FiscalCode { get; set; } = null!;

        public virtual ICollection<SupplierContactRel> SupplierContactRels { get; set; }
    }
}
