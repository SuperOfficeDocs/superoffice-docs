---
uid: help-en-configure-import-settings-(products)
title: Configure import settings (products)
description: Configure import settings (products)
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Configure import settings (products)

[!include[Back up database before import](../includes/caution-backup-before-import.md)]

In the **Import settings** dialog, you can customise the import to include precisely the products you want. To ensure that the quality of the imported data is as good as possible, it is important to specify the correct import settings.

This applies to the following, among other things:

* Duplicates: Select the preferred method for managing products which occur in both the import file and the selected price list.
* Lists: Select the preferred method for managing list elements in the import, e.g. new product categories, product families and product types.

## Manage duplicates

A duplicate occurs if you have the same record in the import file and in the selected price list in the database. In the import settings, you must always specify rules for managing duplicates.

<!-- Fix reuse ID=a21 -->.

* I want to import information that does not exist in the SuperOffice data, but I do not want to overwrite existing information.  
    Select the **Merge - update empty fields** option. Only empty fields in the selected price list will then be updated with imported information.

* The data I want to import has been quality-assured and I want to update the selected price list in SuperOffice.  
    Select the **Replace - overwrite existing** option. The data from the import will overwrite existing fields in selected price list.

* I only want to import new products into the selected price list.  
    Select the **Skip record - do not import** option. Products that already exist in the selected price list will not be updated.

* I want to import all products into selected price list and manage any duplicates myself.  
    Select the **Add always** option.

Under **Product** in the **Import settings** dialog, specify how duplicate products are to be managed.

To do this:

Click the **Duplicate match** list box and select the field(s) that are to be used to identify duplicate products.  
<!-- Fix reuse ID=a11 -->

> [!NOTE]
> To avoid the risk of overwriting data, you should choose the option that is unique for each product.

* **Name**: The product name must be identical.
* **Code**: The product code must be identical.
* **Name + Code**: Both the product name and the product code must be identical.

> [!NOTE]
> The data you have selected for duplicate check MUST exist in the import file. If you select name+code, you import file must at minimum contain these columns.

Click the **Action** list box and choose how duplicate hits are to be managed:

* **Add always**: New products will always be added, even if there are duplicates.
* **Merge - update empty fields**: If existing products in the selected price list have empty fields, these empty fields will be completed with data from the import source. Existing data in the selected price list will not be overwritten.
* **Replace - overwrite existing**: Import data will overwrite existing data in the selected price list.
* **Skip - do not import**: If products already exist in the selected price list, they will not be imported.

## Manage product categories, product families and product types that do not exist in SuperOffice

The import source may, for example, contain product categories that are not registered in SuperOffice. You must then choose how new product categories, product families and product types are to be managed. In the **New values for...** list boxes, you have the following options:

* **Add new item to the list**: New values will be added to SuperOffice.
* **Ignore - set to blank**: No new values will be added to SuperOffice.
