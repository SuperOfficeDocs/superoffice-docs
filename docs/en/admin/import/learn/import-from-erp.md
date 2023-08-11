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

Follow the steps below to import actors (customers, suppliers and individuals) from an ERP system into the SuperOffice database.

## Select actors to be imported from the ERP system

> [!NOTE]
> If the ![icon][img1] ERP sync icon is inactive, you must turn off synchronization in **Quote/Sync** > **Sync** tab.

1. [!include[Open Import](includes/open-import.md)]
2. [!include[Select source](includes/select-source.md)]
3. In the **ERP connection** list, [select the connection][2] you want to import from.
4. In the **Actor type** list, select what you want to import. For example, customers, suppliers or individuals.
5. Click **OK**. The **Search ERP** dialog appears.
6. [Search for the actors you want to import][1], such as all suppliers in a specific town.
7. In the list of search results, select the rows you want to import.
8. Click **Add Import**. The actors are displayed in Settings and maintenance.

> [!NOTE]
> At this stage, actors from the ERP system have not yet been imported into the SuperOffice database. SuperOffice just loads the actors you want to import, so that you can define the import settings.

## Configure the import

1. [!include[Configure import settings](includes/configure-import-settings.md)]

[!include[Preview import](includes/step-preview-import.md)]

1. Remove the checks on the rows you do NOT want to import.

1. After verifying that these are really the data you want to import, click **Import**

## Complete the import

When the import finishes, two lists are displayed:

* New actors that were imported.
* Existing actors that were updated by the import.

Above each list is a link to the selection containing the new/updated actors.

> [!TIP]
> If you want to delete imported actors from SuperOffice, use the selection.

<!-- Referenced links -->
[1]: ../../../search-options/learn/search-criteria.md
[2]: ../../../quote/learn/admin/sync/index.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/admin/import-erp-small.png
