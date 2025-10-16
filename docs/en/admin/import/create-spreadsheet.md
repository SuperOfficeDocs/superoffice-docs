---
uid: help-en-import-create-excel
title: Create an import file
description: In this how-to guide you will learn how to create an import file using the Excel template.
keywords: import, Excel, company, contact, product, spreadsheet
author: digitaldiina
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/import/learn/create-import-file
language: en
---

# Create an import file

To make it easier for you to import contacts, we have created an import template you can download and use to import. In this Excel spreadsheet, we have set up the basic data fields in columns, and all you have to do is copy your contact details into the right cells.

## Companies and contacts

The Excel spreadsheet should as a minimum contain columns with:

* Company names
* Contact names (first name and last name)

> [!TIP]
> Check that the data is up-to-date. For example, are postal addresses and telephone numbers correct?

**Preview of an import file (Excel):**

![Using an import file is the best way to import all your contacts into SuperOffice CRM -screenshot][img2]

[Download the import template for companies and contacts][1] [Excel spreadsheet]

## Products

The Excel spreadsheet should as a minimum contain columns with:

* Product Code
* Product Name
* List Price

You can for instance contains these columns of data: In assortment, product code, name, description, product category, unit, list price, unit minimum price, cost, product name.

> [!TIP]
> View explanations and tips by hovering over column headings.
>
> Make sure to add a unique product code for each row as a duplicate key.

**Preview of an import file (Excel):**

![Using an import file is the best way to import all your products into SuperOffice CRM -screenshot][img5]

[Download the import template for products][2] [Excel spreadsheet]

## Tips

* Some of the fields in SuperOffice CRM are **mandatory**. When you import companies and contacts, make sure to include the columns Category, Business, and Contact/company number in your import file. When you import product information, add Product Code, List price and Name.

* If you want to import several contacts from a company, you need to add one row for each contact person and add the same company name to all the rows.

* Keep in mind that the quality of the data you import determines the quality of your CRM data. We recommend that you go through your data and clean the import file before you start. Imports with huge amounts of data can be quite an exercise to clean up if things go wrong.

> [!NOTE]
> For larger and complex imports, we always recommend using of one of our skilled consultants to ensure that the quality of the data you import into SuperOffice CRM is at its best.

## Related content

* [Choosing settings for your import][3]
* [Import contacts to SuperOffice CRM][4]
* [Import products into a price list][5]

<!-- Referenced links -->
[1]: ../../../assets/downloads/import-template-for-contacts.xlsx
[2]: ../../../assets/downloads/import-template-products.xlsx
[3]: settings.md
[4]: from-excel.md
[5]: products-from-excel.md

<!-- Referenced images -->
[img2]: ../../../media/loc/en/admin/import-with-excel.jpg
[img5]: ../../../media/loc/en/admin/preview-of-an-import-file.png
