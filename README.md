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
- `
