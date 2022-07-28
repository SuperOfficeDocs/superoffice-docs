---
uid: help-en-import-products-from-excel
title: Import products from Excel
description: Import products from Excel
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Import products from Excel

[!include[Back up database before import](../includes/caution-backup-before-import.md)]

If you have an Excel spreadsheet with a list of products, you can easily import them into SuperOffice.

To import an Excel spreadsheet with products into the SuperOffice database:

## A. Export products from an Excel import file

<!-- Fix reuse ID=a1 -->

* You can for instance contains these columns of data: In assortment, product code, name, description, product category, unit, list price, unit minimum price, cost, product name.
* Make sure to add a unique product code for each row as a duplicate key.

1. Open the **Import** screen by clicking the **Import** button in the Navigator ( ![icon](../../../media/icons/admin/Knapp-Import-liten.bmp) ).
2. Click **Products** under **Select an import source**.
3. In the **Import to price list**, select the price list to which you want to import the products.
4. Click the Excel icon ( ![icon](../../../media/icons/admin/import-excel-small.bmp) ) under **Select an import source**. The **Upload file** dialog opens.
5. Click **Upload file** to select the Excel spreadsheet you want to import.
6. Browse to the required Excel spreadsheet and click **Open**. The **File name** field shows the position and name of the file you have selected.
7. Click **Save**. The data from the spreadsheet will be displayed in the table and the name of the import file will be shown at the bottom.

> [!NOTE]
> At this stage, products from Excel have not yet been imported into the SuperOffice database. SuperOffice will only upload the product list from the spreadsheet, so that you can specify the import settings.

## B. Adjust the import

As the Excel spreadsheet may contain anything from just a few to a large number of columns, it is important that the columns with data you want to import are linked to the correct SuperOffice field.

> [!NOTE]
> The spreadsheet must at minimum contain the columns you select for duplicate check in the procedure below (name, code or name+code).

[!include[To do this](../../includes/to-do-this.md)]

1. Find the column containing the name of the products, click the **(No Selection)** column title and select **Product: Name**.
2. Find the column containing the product code, click the **(No Selection)** column title and select **Product: Code**.
3. Select the SuperOffice fields for the rest of the columns in the table. You do not need to do this for the columns you do not want to import.
4. Click **Configure import settings** and adjust the import settings as described in [Configure import settings (products)](Configure-import-settings-(products).md).
5. Click **Next**. The **Preview import** screen will appear.
6. Browse through the import data to fix any issues before the import begins.  
    <!-- Fix reuse ID=a3 -->
    | Icon | Description |
    |---|---|
    | ![icon](../../../media/icons/admin/import-warning.png) | There is a problem with the data on this row. See the explanation text in the table header. |
    | ![icon](../../../media/icons/admin/import-preview-icon-Product-New.bmp) | The product does not already exist and will be added. |
    | ![icon](../../../media/icons/admin/import-preview-icon-Product-Changed.bmp) | The product already exists and will be updated. |
    | empty | No updating. |

7. Remove the checks for the rows you do NOT want to import. If the Excel spreadsheet contained a heading row, you can remove it here.
8. When you have checked that this actually is the data you want to import, click **Import**.

## C. Complete the import

When the import is complete, a list of the imported products will be displayed. Above the list is a link to the updated price list.
