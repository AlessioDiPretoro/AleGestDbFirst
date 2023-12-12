using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            CategorySuppliers = new HashSet<CategorySupplier>();
            SupplierContactRels = new HashSet<SupplierContactRel>();
            SupplierNotes = new HashSet<SupplierNote>();
            SupplierPhotos = new HashSet<SupplierPhoto>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Cap { get; set; } = null!;
        public string Prov { get; set; } = null!;
        public string PIva { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string EmailPec { get; set; } = null!;
        public string PhoneDefault { get; set; } = null!;
        public string PhoneSecondary { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ICollection<CategorySupplier> CategorySuppliers { get; set; }
        public virtual ICollection<SupplierContactRel> SupplierContactRels { get; set; }
        public virtual ICollection<SupplierNote> SupplierNotes { get; set; }
        public virtual ICollection<SupplierPhoto> SupplierPhotos { get; set; }
    }
}
