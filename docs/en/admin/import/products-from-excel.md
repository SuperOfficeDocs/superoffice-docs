---
uid: help-en-import-products-from-excel
title: Import products from Excel
description: In this how-to guide you will learn how you can import all your products, descriptions and product codes.
keywords: import, product, Excel
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/import/learn/import-products-from-excel
language: en
---

# Import products from Excel

[Import][2] is a great way to quickly populate or update your database with price information. If you have an Excel spreadsheet with a list of products, you can easily import them into SuperOffice.

## Before you begin

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Before you start your import, [prepare the Excel file][1]. Checklist:

* The Excel spreadsheet should as a minimum contain columns with Product Code, Product Name, and List Price.
* Make sure to add a unique product code for each row as a duplicate key.

## Export products from an Excel import file

Watch this video or follow the steps to learn how to import your products into SuperOffice CRM using our import template (video length - 4:22):

<!-- markdownlint-disable-next-line MD034 DOCSMD007 -->
> [!Video https://www.youtube.com/embed/xOTB6j2zzNo]

1. [!include[Open Import](includes/open-import.md)]

2. Click **Products** under **Select an import source**.

3. In the **Import to price list**, select the price list you want to import the products to.

4. Click the ![icon][img1] Excel icon under **Select an import source**.

5. In the **Upload file** dialog, click **Upload file** to select the Excel spreadsheet you want to import.

6. Browse to the required Excel spreadsheet and click **Open**. The **File name** field shows the position and name of the file you selected.

7. Click **Save**. The data from the spreadsheet wis displayed in the table and the name of the import file is shown at the bottom.

> [!NOTE]
> At this stage, products from Excel have not yet been imported into the SuperOffice database. SuperOffice will only upload the product list from the spreadsheet, so that you can specify the import settings.

## Adjust the import

As the Excel spreadsheet may contain anything from just a few to a large number of columns, it is important that the columns with data you want to import are linked to the correct SuperOffice field.

> [!NOTE]
> The spreadsheet must at minimum contain the columns you select for duplicate check in the procedure below (name, code or name+code).

1. Find the column containing the name of the products, click the **(No Selection)** column title and select **Product: Name**.

2. Find the column containing the product code, click the **(No Selection)** column title and select **Product: Code**.

3. Select the SuperOffice fields for the rest of the columns in the table. Skip the columns you do not want to import.

4. [!include[Configure import settings](includes/configure-import-settings.md)]

5. Click **Next**. The **Preview import** screen will appear.

6. Browse through the import data to fix any issues before the import begins.

    | Icon | Description |
    |---|---|
    | <i class="ph ph-warning" aria-label="Warning"></i> | There is a problem with the data on this row. See the explanation text in the table header. |
    | ![icon][img3] | The product does not already exist and will be added. |
    | ![icon][img4] | The product already exists and will be updated. |
    | empty | No updating. |

7. Remove the checks for the rows you do NOT want to import. If the Excel spreadsheet contained a heading row, you can remove it here.

8. After checking that this actually is the data you want to import, click **Import**.

## Complete the import

When the import is complete, a list of the imported products are displayed. Above the list is a link to the updated price list.

## Related content

* [Configure import settings][3]
* [Import from ERP][6]

<!-- Referenced links -->
[1]: create-spreadsheet.md
[2]: index.md
[3]: settings.md
[6]: from-erp.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/import-excel-small.png
[img3]: ../../../media/icons/admin/import-preview-icon-product-new.png
[img4]: ../../../media/icons/admin/import-preview-icon-product-changed.png
