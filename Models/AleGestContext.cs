using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AleGestDbFirst.Models
{
    public partial class AleGestContext : DbContext
    {
        public AleGestContext()
        {
        }

        public AleGestContext(DbContextOptions<AleGestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CategoryProduct> CategoryProducts { get; set; } = null!;
        public virtual DbSet<CategorySupplier> CategorySuppliers { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Ddt> Ddts { get; set; } = null!;
        public virtual DbSet<DdtDetail> DdtDetails { get; set; } = null!;
        public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public virtual DbSet<Fidelity> Fidelities { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductPicture> ProductPictures { get; set; } = null!;
        public virtual DbSet<Sale> Sales { get; set; } = null!;
        public virtual DbSet<SaleDetail> SaleDetails { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<SupplierContact> SupplierContacts { get; set; } = null!;
        public virtual DbSet<SupplierContactRel> SupplierContactRels { get; set; } = null!;
        public virtual DbSet<SupplierNote> SupplierNotes { get; set; } = null!;
        public virtual DbSet<SupplierPicture> SupplierPictures { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=AleGest;Trusted_Connection=true;");
            }
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("workstation id=AleGest.mssql.somee.com;packet size=4096;user id=dipretoroalessio_SQLLogin_1;pwd=xg8anybg1s;data source=AleGest.mssql.somee.com;persist security info=False;initial catalog=AleGest");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
            });

            modelBuilder.Entity<CategoryProduct>(entity =>
            {
                entity.ToTable("CategoryProduct");

                entity.HasIndex(e => e.CategoryId, "IX_CategoryProduct_CategoryId");

                entity.HasIndex(e => e.ProductId, "IX_CategoryProduct_ProductId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryProducts)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CategoryProducts)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<CategorySupplier>(entity =>
            {
                entity.ToTable("CategorySupplier");

                entity.HasIndex(e => e.CategoryId, "IX_CategorySupplier_CategoryId");

                entity.HasIndex(e => e.SupplierId, "IX_CategorySupplier_SupplierId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategorySuppliers)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.CategorySuppliers)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.PIva).HasColumnName("P_Iva");
            });

            modelBuilder.Entity<Ddt>(entity =>
            {
                entity.ToTable("Ddt");

                entity.HasIndex(e => e.DocumentTypeId, "IX_Ddt_DocumentTypeId");

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.Ddts)
                    .HasForeignKey(d => d.DocumentTypeId);
            });

            modelBuilder.Entity<DdtDetail>(entity =>
            {
                entity.HasIndex(e => e.DdtId, "IX_DdtDetails_DdtId");

                entity.HasIndex(e => e.ProductId, "IX_DdtDetails_ProductId");

                entity.HasOne(d => d.Ddt)
                    .WithMany(p => p.DdtDetails)
                    .HasForeignKey(d => d.DdtId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DdtDetails)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("DocumentType");
            });

            modelBuilder.Entity<Fidelity>(entity =>
            {
                entity.ToTable("Fidelity");

                entity.HasIndex(e => e.ClientId, "IX_Fidelity_ClientId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Fidelities)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.HasIndex(e => e.ClientId, "IX_Invoice_ClientId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasIndex(e => e.InvoiceId, "IX_InvoiceDetails_InvoiceId");

                entity.HasIndex(e => e.ProductId, "IX_InvoiceDetails_ProductId");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.InvoiceId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.CodeInternal).HasColumnName("Code_internal");

                entity.Property(e => e.CodeProducer).HasColumnName("Code_producer");

                entity.Property(e => e.CodeSeller).HasColumnName("Code_seller");
            });

            modelBuilder.Entity<ProductPicture>(entity =>
            {
                entity.ToTable("ProductPicture");

                entity.HasIndex(e => e.ProductId, "IX_ProductPicture_ProductId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPictures)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("Sale");

                entity.HasIndex(e => e.ClientId, "IX_Sale_ClientId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ClientId);
            });

            modelBuilder.Entity<SaleDetail>(entity =>
            {
                entity.HasIndex(e => e.ProductId, "IX_SaleDetails_ProductId");

                entity.HasIndex(e => e.SaleId, "IX_SaleDetails_SaleId");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SaleDetails)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.Sale)
                    .WithMany(p => p.SaleDetails)
                    .HasForeignKey(d => d.SaleId);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.HasIndex(e => e.ProductId, "IX_Supplier_ProductId");

                entity.Property(e => e.PIva).HasColumnName("P_Iva");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Suppliers)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<SupplierContact>(entity =>
            {
                entity.ToTable("SupplierContact");
            });

            modelBuilder.Entity<SupplierContactRel>(entity =>
            {
                entity.ToTable("SupplierContactRel");

                entity.HasIndex(e => e.SupplierContactId, "IX_SupplierContactRel_SupplierContactId");

                entity.HasIndex(e => e.SupplierId, "IX_SupplierContactRel_SupplierId");

                entity.HasOne(d => d.SupplierContact)
                    .WithMany(p => p.SupplierContactRels)
                    .HasForeignKey(d => d.SupplierContactId);

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierContactRels)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<SupplierNote>(entity =>
            {
                entity.ToTable("SupplierNote");

                entity.HasIndex(e => e.SupplierId, "IX_SupplierNote_SupplierId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierNotes)
                    .HasForeignKey(d => d.SupplierId);
            });

            modelBuilder.Entity<SupplierPicture>(entity =>
            {
                entity.ToTable("SupplierPicture");

                entity.HasIndex(e => e.SupplierId, "IX_SupplierPicture_SupplierId");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.SupplierPictures)
                    .HasForeignKey(d => d.SupplierId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
