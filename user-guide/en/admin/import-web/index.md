---
uid: help-en-import-web
title: Import web
description: Import web
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Import

![icon][img1] We recommend that you contact SuperOffice Support in order to back up the SuperOffice database before you import large amounts of data. See [Import][7] (Windows Client settings).

In the **Import** screen, you can import companies, contacts and products into SuperOffice. You can import both new companies/contacts and existing companies/contacts with updated data.

> [!NOTE]
> For every import, a selection will be created in SuperOffice CRM. This allows you to further process the imported companies/contacts, or to delete them.

The Import function supports imports from the following sources:

* [Excel][1]. Using the Excel format, you can import companies, contacts and [products][5] from other applications and formats.
* [Outlook][2]. Imports companies and contacts from Microsoft Outlook.
* [Gmail][3]. Imports companies and contacts from Google Gmail.
* [ERP][4]. Imports actors (customers, suppliers and individuals) from an ERP system.

> [!NOTE]
> To import other data like projects, sales, currencies, post codes and red-letter days, you must use the [Import][7] feature in Windows Client settings.

Here are some examples of various types of import:

## Import into empty SuperOffice database

If you want to import your companies and/or contacts into an empty SuperOffice database, you can for example do the following:

* Import all company and contact data. Make sure you link all columns in the import to the correct SuperOffice fields and specify the correct [Import settings][6] in order to include all the necessary data from the import source.
* Import companies only: If you only want to import companies without contacts, go to[Import settings][6] and select the **None - do not import contact** option in the **Duplicate match** list box under **Contact**.
* Import contacts only: If you only want to import contacts without companies, go to [Import settings][6] and select the **Import contacts without company** option in the **If no company name** list box under **Contact**.

## Update old data in SuperOffice

If SuperOffice contains obsolete information and you want to update these fields with the correct information from Excel, for example, you should use the **Replace - overwrite existing** action when importing. Any empty SuperOffice fields will also be updated with new information.

## Import additional information

If you are missing a lot of information about customers and contacts in SuperOffice, you have the option of updating only empty fields without overwriting the existing information. To do this, use the **Merge - update empty fields** action when importing companies and contacts.

<!-- Referenced links -->
[1]: import-from-excel.md
[2]: import-from-outlook.md
[3]: import-from-gmail.md
[4]: import-from-erp.md
[5]: import-products-from-excel.md
[6]: import-settings-web.md
[7]: ../win-client/import.md

<!-- Referenced images -->
[img1]: ../../../media/icons/admin/utropstegn.bmp
