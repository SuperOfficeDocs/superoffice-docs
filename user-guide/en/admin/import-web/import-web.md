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

![icon](../media/utropstegn.bmp) We recommend that you contact SuperOffice Support in order to back up the SuperOffice database before you import large amounts of data. See [Import](../chap04/Import.md) (Windows Client settings).

In the **Import** screen, you can import companies, contacts and products into SuperOffice. You can import both new companies/contacts and existing companies/contacts with updated data.

> [!NOTE]
> For every import, a selection will be created in SuperOffice CRM. This allows you to further process the imported companies/contacts, or to delete them.

The Import function supports imports from the following sources:

* [Excel](Import-from-Excel.md). Using the Excel format, you can import companies, contacts and [products](Import-products-from-Excel.md) from other applications and formats.
* [Outlook](Import-from-Outlook.md). Imports companies and contacts from Microsoft Outlook.
* [Gmail](Import-from-Gmail.md). Imports companies and contacts from Google Gmail.
* [ERP](import-from-ERP.md). Imports actors (customers, suppliers and individuals) from an ERP system.

> [!NOTE]
> To import other data like projects, sales, currencies, post codes and red-letter days, you must use the [Import](../chap04/Import.md) feature in Windows Client settings.

Here are some examples of various types of import:

## Import into empty SuperOffice database

If you want to import your companies and/or contacts into an empty SuperOffice database, you can for example do the following:

* Import all company and contact data. Make sure you link all columns in the import to the correct SuperOffice fields and specify the correct [Import settings](Import-settings-web.md) in order to include all the necessary data from the import source.
* Import companies only: If you only want to import companies without contacts, go to[Import settings](Import-settings-web.md) and select the **None - do not import contact** option in the **Duplicate match** list box under **Contact**.
* Import contacts only: If you only want to import contacts without companies, go to [Import settings](Import-settings-web.md) and select the **Import contacts without company** option in the **If no company name** list box under **Contact**.

## Update old data in SuperOffice

If SuperOffice contains obsolete information and you want to update these fields with the correct information from Excel, for example, you should use the **Replace - overwrite existing** action when importing. Any empty SuperOffice fields will also be updated with new information.

## Import additional information

If you are missing a lot of information about customers and contacts in SuperOffice, you have the option of updating only empty fields without overwriting the existing information. To do this, use the **Merge - update empty fields** action when importing companies and contacts.
