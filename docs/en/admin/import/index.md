---
uid: help-en-import
title: Import
description: Import
keywords: import
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: concept
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /en/admin/import/learn/index
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

* [Excel][1]: Using the Excel format, you can import companies, contacts and [products][5] from other applications and formats.
* [Outlook][2]: Imports companies and contacts from Microsoft Outlook.
* [Gmail][3]: Imports companies and contacts from Google Gmail.
* [ERP][4]: Imports actors (customers, suppliers and individuals) from an ERP system.

> [!NOTE]
> To import other data like projects, sales, currencies, post codes and red-letter days, you must use the [Import][7] feature in Windows Client settings.

## Import into empty SuperOffice database

* Import all company and contact data. Make sure you link all columns in the import to the correct SuperOffice fields and specify the correct [Import settings][6] to include all the necessary data from the import source.

* Import companies only: If you only want to import companies without contacts, go to [Import settings][6] and select the **None - do not import contact** option in the **Duplicate match** list box under **Contact**.

* Import contacts only: If you only want to import contacts without companies, go to [Import settings][6] and select the **Import contacts without company** option in the **If no company name** list box under **Contact**.

## Update old data in SuperOffice

If SuperOffice contains obsolete information and you want to update these fields with the correct information from Excel, for example, you should use the **Replace - overwrite existing** action when importing. Any empty SuperOffice fields will also be updated with new information.

## Import additional information

If you are missing a lot of information about customers and contacts in SuperOffice, use the **Merge - update empty fields** action when importing companies and contacts. This will update only empty fields without overwriting the existing information.

## Related content

* [Configure import settings][6]
* [Create the import file][11]

<!-- Referenced links -->
[1]: from-excel.md
[2]: from-outlook.md
[3]: from-gmail.md
[4]: from-erp.md
[5]: products-from-excel.md
[6]: settings.md
[7]: https://help.superoffice.com/docs/10.3/en/onsite/win-client/learn/import/index.html
[11]: create-spreadsheet.md

<!-- Referenced images -->
