using System;
using System.Collections.Generic;

namespace AleGestDbFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            CategoryProducts = new HashSet<CategoryProduct>();
            DdtDetails = new HashSet<DdtDetail>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
            ProductPhotos = new HashSet<ProductPicture>();
            SaleDetails = new HashSet<SaleDetail>();
            Suppliers = new HashSet<Supplier>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Ean { get; set; } = null!;
        public string CodeInternal { get; set; } = null!;
        public string CodeSeller { get; set; } = null!;
        public string CodeProducer { get; set; } = null!;
        public double Price { get; set; }
        public string PhotoMain { get; set; } = null!;

        public virtual ICollection<CategoryProduct> CategoryProducts { get; set; }
        public virtual ICollection<DdtDetail> DdtDetails { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<ProductPicture> ProductPhotos { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
