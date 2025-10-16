---
uid: help-en-import-from-erp
title: import from ERP
description: import from ERP
keywords: import, ERP
author: digitaldiina
date: 04.28.2025
version: 10.5.4
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: 
  - /en/quote/learn/admin/sync/sync-import-from-erp
  - /en/admin/import/learn/import-from-erp
language: en
---

# Import from ERP

[!include[Back up database before import](includes/caution-backup-before-import.md)]

Follow the steps below to import actors (customers, suppliers and individuals) from an ERP system into the SuperOffice database.

## Select actors to be imported from the ERP system

1. [!include[Open Import](includes/open-import.md)]
2. Under **Select an import source**, select **ERP sync**. The **Select ERP connection** dialog opens.

    If the **ERP sync** button is inactive, you must turn off synchronization in **Quote/Sync** > **Sync** tab.

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
[1]: ../../search-options/learn/search-criteria.md
[2]: ../../erp/admin/add-connection.md

<!-- Referenced images -->
