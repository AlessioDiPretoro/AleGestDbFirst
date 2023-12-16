# Schemas

## Category
- `id` [...]
- `name` [...]
- `description` [...]
- `categoryProducts` [...]
- `categorySuppliers` [...]

## CategoryProduct
- `id` [...]
- `categoryId` [...]
- `productId` [...]
- `category` Category{...}
- `product` Product{...}

## CategorySupplier
- `id` [...]
- `categoryId` [...]
- `supplierId` [...]
- `category` Category{...}
- `supplier` Supplier{...}

## Client
- `id` [...]
- `name` [...]
- `surname` [...]
- `email` [...]
- `emailPec` [...]
- `phone` [...]
- `cell` [...]
- `address` [...]
- `city` [...]
- `cap` [...]
- `prov` [...]
- `fiscalCode` [...]
- `pIva` [...]
- `isPrivate` [...]
- `fidelities` [...]
- `invoices` [...]
- `sales` [...]

## Ddt
- `id` [...]
- `documentTypeId` [...]
- `supplierId` [...]
- `date` [...]
- `number` [...]
- `note` [...]
- `discount` [...]
- `documentType` DocumentType{...}
- `ddtDetails` [...]

## DdtDetail
- `id` [...]
- `ddtId` [...]
- `productId` [...]
- `quantity` [...]
- `price` [...]
- `discount` [...]
- `note` [...]
- `ddt` Ddt{...}
- `product` Product{...}

## DocumentType
- `id` [...]
- `name` [...]
- `ddts` [...]

## Fidelity
- `id` [...]
- `clientId` [...]
- `number` [...]
- `activePromo` [...]
- `client` Client{...}

## Invoice
- `id` [...]
- `clientId` [...]
- `checkOut` [...]
- `date` [...]
- `fidelity` [...]
- `extra` [...]
- `discount` [...]
- `client` Client{...}
- `invoiceDetails` [...]

## InvoiceDetail
- `id` [...]
- `invoiceId` [...]
- `productId` [...]
- `quantity` [...]
- `price` [...]
- `discount` [...]
- `invoice` Invoice{...}
- `product` Product{...}

## Product
- `id` [...]
- `description` [...]
- `ean` [...]
- `codeInternal` [...]
- `codeSeller` [...]
- `codeProducer` [...]
- `price` [...]
- `PictureMain` [...]
- `categoryProducts` [...]
- `ddtDetails` [...]
- `invoiceDetails` [...]
- `productPictures` [...]
- `saleDetails` [...]
- `suppliers` [...]

## ProductPicture
- `id` [...]
- `fileName` [...]
- `filePath` [...]
- `productId` [...]
- `product` Product{...}

## Sale
- `id` [...]
- `clientId` [...]
- `checkOut` [...]
- `date` [...]
- `fidelity` [...]
- `extra` [...]
- `discount` [...]
- `client` Client{...}
- `saleDetails` [...]

## SaleDetail
- `id` [...]
- `saleId` [...]
- `productId` [...]
- `quantity` [...]
- `price` [...]
- `discount` [...]
- `product` Product{...}
- `sale` Sale{...}

## Supplier
- `id` [...]
- `name` [...]
- `address` [...]
- `city` [...]
- `cap` [...]
- `prov` [...]
- `pIva` [...]
- `email` [...]
- `emailPec` [...]
- `phoneDefault` [...]
- `phoneSecondary` [...]
- `fax` [...]
- `logo` [...]
- `productId` [...]
- `product` Product{...}
- `categorySuppliers` [...]
- `supplierContactRels` [...]
- `supplierNotes` [...]
- `supplierPictures` [...]

## SupplierContact
- `id` [...]
- `name` [...]
- `surname` [...]
- `email` [...]
- `emailPec` [...]
- `phone` [...]
- `cell` [...]
- `address` [...]
- `city` [...]
- `cap` [...]
- `prov` [...]
- `fiscalCode` [...]
- `supplierContactRels` [...]

## SupplierContactRel
- `id` [...]
- `supplierContactId` [...]
- `supplierId` [...]
- `supplier` Supplier{...}
- `supplierContact` SupplierContact{...}

## SupplierNote
- `id` [...]
- `title` [...]
- `body` [...]
- `createdDate` [...]
- `allarmDate` [...]
- `supplierId` [...]
- `supplier` Supplier{...}

## SupplierPicture
- `id` [...]
- `fileName` [...]
- `filePath` [...]
- `supplierId` [...]
- `supplier` Supplier{...}
