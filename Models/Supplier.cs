﻿using System;
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
            SupplierPhotos = new HashSet<SupplierPicture>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Cap { get; set; }
        public string? Prov { get; set; }
        public string? PIva { get; set; }
        public string? Email { get; set; }
        public string? EmailPec { get; set; }
        public string? PhoneDefault { get; set; }
        public string? PhoneSecondary { get; set; }
        public string? Fax { get; set; }
        public string? Logo { get; set; }
        public int? ProductId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual ICollection<CategorySupplier> CategorySuppliers { get; set; }
        public virtual ICollection<SupplierContactRel> SupplierContactRels { get; set; }
        public virtual ICollection<SupplierNote> SupplierNotes { get; set; }
        public virtual ICollection<SupplierPicture> SupplierPhotos { get; set; }
    }
}
