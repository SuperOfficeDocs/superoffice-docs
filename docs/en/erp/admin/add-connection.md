---
uid: help-en-erp-add-connection
title: Add a sync connector and ERP connection
description: Learn how to install a sync app, add a sync connector, and create ERP connections to enable synchronization between SuperOffice CRM and an ERP system.
keywords: set up ERP sync, add sync connector, sync connector, add ERP connection, test ERP connection, ERP connection, connector, sync, ERP
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from:
  - /en/quote/learn/admin/sync/sync-add-erp-connection
  - /en/quote/learn/admin/sync/sync-connector-add
---

# Add a sync connector and ERP connection

[!include[Requirement](../../includes/req-dev-tools.md)]

To synchronize data between SuperOffice CRM and an ERP system, you must first install a sync app. Then, in Settings and maintenance, you must add a sync connector and configure one or more ERP connections.

## 1. Install the sync app

Before you can add a sync connector, you need a sync app for your ERP system.

1. Check the [SuperOffice App Store][7] for a standard sync app that supports your ERP system.

    If no standard app is available, or if you require a customized version, you can have one [developed by a SuperOffice partner][8] or your in-house team.

1. Follow the app provider's instructions to install and register the connector.

## <a id="connector"></a>2. Add a sync connector

1. In Settings and maintenance, select <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Quote/Sync** in the navigator.

1. Open the **Sync** tab.

1. Click **Add** below the **Sync Connectors** list.

1. Enter a name and the connector URL.

1. Click **OK**.

The sync connector is added to the list.

![Sync tab in Settings and maintenance with one sync connector -screenshot][img1]

## <a id="connection"></a>3. Add an ERP connection

1. In the **Sync** tab, click **Add** below the **ERP connections** list.

    The **Define new ERP connection** dialog opens.

    ![Define new ERP connection dialog with sample input and configuration fields -screenshot][img2]

1. Enter a name for the ERP connection.

1. Select the sync connector to use from the list.

1. Define the **scope**:

    * **Everyone:** All users can access and use this ERP connection.
    * **Specific users and groups:** Only selected users and groups can access it. Click the link to open the scope dialog and select access.

        ![Configure scope dialog with user group selection][img3]

1. Fill in the **configuration fields**. These are specific to the selected connector and may include authentication, file paths, numeric settings, or other technical values.

1. Optionally, enter a description to clarify the purpose of this connection.

1. Click **Test ERP connection**.

    If the test fails, check the connector URL and the configuration fields. You must fix the issue before continuing.

1. Click **OK** to save the connection. The new ERP connection appears in the list.

    If the **OK** button appears dimmed, it means either the test has not succeeded or some mandatory fields are missing.

> [!NOTE]
> Before the ERP connection can be used, you must configure synchronization settings and activate it. See [Configure ERP connection][1].

## Next steps

* [Configure field mapping and lists][1]
* [Define default values][3]
* [Select the order of the ERP fields][4] displayed in the ERP tab in SuperOffice CRM
* [Set sync priority][5]
* [Import data from ERP][6]

<!-- Referenced links -->
[1]: configure.md
[3]: configure.md#defaults
[4]: configure.md#rank
[5]: configure.md#priority
[6]: ../../admin/import/from-erp.md
[8]: ../../../en/developer-portal/custom-app/index.md
[7]: https://online.superoffice.com/appstore/app/search?phrase=sync

<!-- Referenced images -->
[img1]: ../../../media/loc/en/erp/sync-connectors-list.png
[img2]: ../../../media/loc/en/erp/define-erp-connection.png
[img3]: ../../../media/loc/en/erp/configure-scope.png
