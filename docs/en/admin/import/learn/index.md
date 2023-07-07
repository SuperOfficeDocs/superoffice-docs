---
uid: help-en-import
title: Import
description: Import
author: SuperOffice RnD
so.date: 02.22.2023
keywords: import
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Import contacts and product data

An empty CRM database won't help you manage your contacts. By importing your customer data all in one go using our import feature, you can quickly start managing your customer relationships in SuperOffice CRM.

Using the Windows client? See [Windows Client settings][7].

[!include[Back up database before import](includes/caution-backup-before-import.md)]

In the **Import** screen, you can import companies, contacts and products into SuperOffice. You can import both new companies/contacts and existing companies/contacts with updated data.

> [!NOTE]
> For every import, a selection is created in SuperOffice CRM. This allows you to further process the imported companies/contacts, or to delete them.

## Sources

The Import function supports imports from the following sources:

* [Excel][1]. Using the Excel format, you can import companies, contacts and [products][5] from other applications and formats.
* [Outlook][2]. Imports companies and contacts from Microsoft Outlook.
* [Gmail][3]. Imports companies and contacts from Google Gmail.
* [ERP][4]. Imports actors (customers, suppliers and individuals) from an ERP system.

> [!NOTE]
> To import other data like projects, sales, currencies, post codes and red-letter days, you must use the [Import][7] feature in Windows Client settings.

## Import into empty SuperOffice database

* Import all company and contact data. Make sure you link all columns in the import to the correct SuperOffice fields and specify the correct [Import settings][6] to include all the necessary data from the import source.

* Import companies only: If you only want to import companies without contacts, go to [Import settings][6] and select the **None - do not import contact** option in the **Duplicate match** list box under **Contact**.

* Import contacts only: If you only want to import contacts without companies, go to [Import settings][6] and select the **Import contacts without company** option in the **If no company name** list box under **Contact**.

To make it easier for you to import contacts, we have created an import template you can download and use to import. In this Excel spreadsheet, we've set up the basic data fields in columns, and all you have to do is copy your contact details into the right cells.

* Download the [import template for companies and contacts (Excel spreadsheet)][8].
* Download the [import template for products (Excel spreadsheet)][9].

### Three tips to create the import file

1. Some of the fields in SuperOffice CRM are mandatory. When you import companies and contacts, make sure to include the columns Category, Business, and Contact/company number in your import file. When you import product information, add Product Code, List price and Name.
1. If you want to import several contacts from a company, you need to add one row for each contact person and add the same company name to all the rows.
1. Keep in mind that the quality of the data you import determines the quality of your CRM data. We recommend that you go through your data and clean the import file before you start. Imports with huge amounts of data can be quite an exercise to clean up if things go wrong.

> [!TIP]
> For larger and complex imports, we always recommend using of one of [our skilled consultants][10] to ensure that the quality of the data you import into SuperOffice CRM is at its best.

### Choosing settings for your import

Adjusting the import settings will save you time and make it easier to import your data correctly. Here are two examples of what you should consider before you import your contact or product information:

* You can define what the system should do if you import contacts that already exist in SuperOffice CRM. The system can overwrite or skip updating – it’s your choice.
* You can choose to have the system create new categories automatically, if you use a category that doesn’t exist in SuperOffice CRM in your import file.

## Update old data in SuperOffice

If SuperOffice contains obsolete information and you want to update these fields with the correct information from Excel, for example, you should use the **Replace - overwrite existing** action when importing. Any empty SuperOffice fields will also be updated with new information.

## Import additional information

If you are missing a lot of information about customers and contacts in SuperOffice, use the **Merge - update empty fields** action when importing companies and contacts. This will update only empty fields without overwriting the existing information.

## Related topics

* [Configure import settings][6]
* [Create the import file][11]

<!-- Referenced links -->
[1]: import-from-excel.md
[2]: import-from-outlook.md
[3]: import-from-gmail.md
[4]: import-from-erp.md
[5]: import-products-from-excel.md
[6]: configure-import-settings.md
[7]: ../../../onsite/win-client/learn/import/index.md
[8]: https://community.superoffice.com/globalassets/user--admin/learning/admin-guide/import/import-template-for-contacts.xlsx
[9]: https://community.superoffice.com/globalassets/user--admin/learning/admin-guide/import/import_template_products.xlsx
[10]: https://www.superoffice.com/consulting/contact/
[11]: create-import-file.md

<!-- Referenced images -->
