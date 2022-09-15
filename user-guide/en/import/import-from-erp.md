---
uid: help-en-import-from-erp
title: import from ERP
description: import from ERP
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, import
so.topic: help
language: en
---

# Import from ERP

[!include[Back up database before import](includes/caution-backup-before-import.md)]

This is how to proceed when importing actors (customers, suppliers and individuals) from an ERP system into the SuperOffice database:

## A. Select actors to be imported from the ERP system

> [!NOTE]
> If the **ERP Sync** icon ( ![icon][img1] ) is inactive, you must turn off synchronisation in **Quote/Sync** &gt; **Sync** tab.

1. [!include[Open Import](includes/open-import.md)]
2. [!include[Select source](includes/select-source.md)]
3. In the **ERP connection** list, select the connection you want to import from (see [Sync][2]).
4. In the **Actor type** list, select what you want to import. These might, for example, be customers, suppliers or individuals.
5. Click **OK**. The **Search ERP** dialog appears.
6. Search for the actors you want to import, such as all suppliers in a specific town. [!include[See search criteria](../includes/see-search-admin.md)]
7. In the list of search results, select the rows you want to import.
8. Click **Add Import**. The actors are displayed in Settings and maintenance.

> [!NOTE]
> At this stage, actors from the ERP system have not yet been imported into the SuperOffice database. SuperOffice just loads the actors you want to import, so that you can define the import settings.

## B. Configure the import

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Remove the checks on the rows you do NOT want to import.

1. Once you have verified that these are really the data you want to import, click **Import**

## C. Complete the import

Once the import has finished, two lists are displayed:

* New actors that have been imported.
* Existing actors that have been updated by the import.

Above each list is a link to the selection containing the new/updated actors.

> [!TIP]
> If you have imported new actors, but want to delete them from SuperOffice, you can do this by using the selection.

<!-- Referenced links -->
[2]: ../admin/quote-sync/sync/index.md

<!-- Referenced images -->
[img1]: ../../media/icons/admin/import-erp-small.bmp
