---
uid: help-en-import-from-erp
title: import from ERP
description: import from ERP
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Import from ERP

![icon](../media/utropstegn.bmp) We recommend that you contact SuperOffice Support in order to back up the SuperOffice database before you import large amounts of data.

This is how to proceed when importing actors (customers, suppliers and individuals) from an ERP system into the SuperOffice database:

## A. Select actors to be imported from the ERP system

> [!NOTE]
> If the **ERP Sync** icon ( ![icon](../media/import-ERP-small.bmp) ) is inactive, you must turn off synchronisation in **Quote/Sync** &gt; **Sync** tab.

1. Open the **Import** screen by clicking the **Import** button in the Navigator ( ![icon](../media/Knapp-Import-liten.bmp) ).
2. Click the **ERP Sync** icon ( ![icon](../media/import-ERP-small.bmp) ) under **Select an import source**. The **Select ERP connection** dialog opens.
3. In the **ERP connection** list, select the connection you want to import from (see [Sync](../quote-sync/quotesync-tab-sync.md)).
4. In the **Actor type** list, select what you want to import. These might, for example, be customers, suppliers or individuals.
5. Click **OK**. The **Search ERP** dialog appears.
6. Search for the actors you want to import, such as all suppliers in a specific town. For more about search options, see [Use search criteria](../chap06/using-search-criteria.md).
7. In the list of search results, select the rows you want to import.
8. Click **Add Import**. The actors are displayed in Settings and maintenance.

> [!NOTE]
> At this stage, actors from the ERP system have not yet been imported into the SuperOffice database. SuperOffice just loads the actors you want to import, so that you can define the import settings.

## B. Configure the import

1. Click **Configure import settings** and adjust the import settings as described in [Configure import settings](Import-settings-web.md).

<!-- -->

1. Click **Next** when you have finished. The **Preview** window opens.
    <!-- Fix reuse -->What do the various icons in the table mean?
2. In **Preview** you can browse through the import data before the import begins.
    <!-- Fix reuse ID=a2 -->
    Rows without icons are not imported. If you see that many contacts are not being imported, this may be because they are not linked to a company. In that case, you can do one of the following:

    If the contact is actually linked to a company, you need to return to the import source (Gmail, Outlook or Excel) and specify a company for the contact. Then start the import afresh.
    If the contact is not linked to a company, but should be registered under his or her own name in SuperOffice, you need to set up the person as a company, as follows:
    1. Click **Previous** and **Configure import settings**.
    2. Click the **If no company name** list under **Contact**.
    3. Select **Create company using contact name**.
    4. Click **Save**.
    5. Click **Next**, and check that the ![icon](../media/import-preview-icon-Company-New.bmp) icon is displayed next to the contact. The person will be registered as a company in SuperOffice CRM with himself or herself as the only contact.
3. Remove the checks on the rows you do NOT want to import.
4. Once you have verified that these are really the data you want to import, click **Import**

## C. Complete the import

Once the import has finished, two lists are displayed:

* New actors that have been imported.
* Existing actors that have been updated by the import.

Above each list is a link to the selection containing the new/updated actors.

> [!TIP]
> If you have imported new actors, but want to delete them from SuperOffice, you can do this by using the selection.
