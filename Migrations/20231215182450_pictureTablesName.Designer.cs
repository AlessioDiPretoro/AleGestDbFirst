﻿// <auto-generated />
using System;
using AleGestDbFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AleGestDbFirst.Migrations
{
    [DbContext(typeof(AleGestContext))]
    [Migration("20231215182450_pictureTablesName")]
    partial class pictureTablesName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AleGestDbFirst.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.CategoryProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CategoryId" }, "IX_CategoryProduct_CategoryId");

                    b.HasIndex(new[] { "ProductId" }, "IX_CategoryProduct_ProductId");

                    b.ToTable("CategoryProduct", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.CategorySupplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CategoryId" }, "IX_CategorySupplier_CategoryId");

                    b.HasIndex(new[] { "SupplierId" }, "IX_CategorySupplier_SupplierId");

                    b.ToTable("CategorySupplier", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cell")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FiscalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("P_Iva");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Ddt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DocumentTypeId" }, "IX_Ddt_DocumentTypeId");

                    b.ToTable("Ddt", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.DdtDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DdtId")
                        .HasColumnType("int");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "DdtId" }, "IX_DdtDetails_DdtId");

                    b.HasIndex(new[] { "ProductId" }, "IX_DdtDetails_ProductId");

                    b.ToTable("DdtDetails");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DocumentType", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Fidelity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("ActivePromo")
                        .HasColumnType("bit");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ClientId" }, "IX_Fidelity_ClientId");

                    b.ToTable("Fidelity", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CheckOut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Extra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fidelity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ClientId" }, "IX_Invoice_ClientId");

                    b.ToTable("Invoice", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.InvoiceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "InvoiceId" }, "IX_InvoiceDetails_InvoiceId");

                    b.HasIndex(new[] { "ProductId" }, "IX_InvoiceDetails_ProductId");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodeInternal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Code_internal");

                    b.Property<string>("CodeProducer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Code_producer");

                    b.Property<string>("CodeSeller")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Code_seller");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ean")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoMain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.ProductPicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_ProductPhoto_ProductId");

                    b.ToTable("ProductPhoto", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CheckOut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<string>("Extra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fidelity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ClientId" }, "IX_Sale_ClientId");

                    b.ToTable("Sale", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_SaleDetails_ProductId");

                    b.HasIndex(new[] { "SaleId" }, "IX_SaleDetails_SaleId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("P_Iva");

                    b.Property<string>("PhoneDefault")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneSecondary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Prov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "ProductId" }, "IX_Supplier_ProductId");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cell")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPec")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FiscalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SupplierContact", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierContactRel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SupplierContactId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "SupplierContactId" }, "IX_SupplierContactRel_SupplierContactId");

                    b.HasIndex(new[] { "SupplierId" }, "IX_SupplierContactRel_SupplierId");

                    b.ToTable("SupplierContactRel", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierNote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AllarmDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "SupplierId" }, "IX_SupplierNote_SupplierId");

                    b.ToTable("SupplierNote", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierPicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "SupplierId" }, "IX_SupplierPhoto_SupplierId");

                    b.ToTable("SupplierPhoto", (string)null);
                });

            modelBuilder.Entity("AleGestDbFirst.Models.CategoryProduct", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Category", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AleGestDbFirst.Models.Product", "Product")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.CategorySupplier", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Category", "Category")
                        .WithMany("CategorySuppliers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AleGestDbFirst.Models.Supplier", "Supplier")
                        .WithMany("CategorySuppliers")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Ddt", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.DocumentType", "DocumentType")
                        .WithMany("Ddts")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentType");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.DdtDetail", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Ddt", "Ddt")
                        .WithMany("DdtDetails")
                        .HasForeignKey("DdtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AleGestDbFirst.Models.Product", "Product")
                        .WithMany("DdtDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ddt");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Fidelity", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Client", "Client")
                        .WithMany("Fidelities")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Invoice", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Client", "Client")
                        .WithMany("Invoices")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.InvoiceDetail", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Invoice", "Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AleGestDbFirst.Models.Product", "Product")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.ProductPicture", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Product", "Product")
                        .WithMany("ProductPhotos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Sale", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Client", "Client")
                        .WithMany("Sales")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SaleDetail", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Product", "Product")
                        .WithMany("SaleDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AleGestDbFirst.Models.Sale", "Sale")
                        .WithMany("SaleDetails")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Supplier", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Product", "Product")
                        .WithMany("Suppliers")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierContactRel", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.SupplierContact", "SupplierContact")
                        .WithMany("SupplierContactRels")
                        .HasForeignKey("SupplierContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AleGestDbFirst.Models.Supplier", "Supplier")
                        .WithMany("SupplierContactRels")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");

                    b.Navigation("SupplierContact");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierNote", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Supplier", "Supplier")
                        .WithMany("SupplierNotes")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierPicture", b =>
                {
                    b.HasOne("AleGestDbFirst.Models.Supplier", "Supplier")
                        .WithMany("SupplierPhotos")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Category", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("CategorySuppliers");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Client", b =>
                {
                    b.Navigation("Fidelities");

                    b.Navigation("Invoices");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Ddt", b =>
                {
                    b.Navigation("DdtDetails");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.DocumentType", b =>
                {
                    b.Navigation("Ddts");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Invoice", b =>
                {
                    b.Navigation("InvoiceDetails");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Product", b =>
                {
                    b.Navigation("CategoryProducts");

                    b.Navigation("DdtDetails");

                    b.Navigation("InvoiceDetails");

                    b.Navigation("ProductPhotos");

                    b.Navigation("SaleDetails");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.Supplier", b =>
                {
                    b.Navigation("CategorySuppliers");

                    b.Navigation("SupplierContactRels");

                    b.Navigation("SupplierNotes");

                    b.Navigation("SupplierPhotos");
                });

            modelBuilder.Entity("AleGestDbFirst.Models.SupplierContact", b =>
                {
                    b.Navigation("SupplierContactRels");
                });
#pragma warning restore 612, 618
        }
    }
}
