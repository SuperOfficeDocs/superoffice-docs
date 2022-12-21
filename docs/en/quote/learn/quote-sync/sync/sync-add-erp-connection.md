---
uid: help-en-sync-add-erp-connection
title: sync add erp connection
description: sync add erp connection
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add an ERP connection (Sync Connector)

Each Sync Connector must have an ERP connection with configuration data for linking the Sync Connector with SuperOffice.

## To add an ERP connection

1. Go to the **Sync** tab in the **Quote/Sync** screen.

[!include[Define new ERP connection](../includes/step-define-new-erp-connection.md)]

1. Selected the required **ERP Sync Connector** in the list. This list is identical to **Sync Connectors**.

1. Select the **Scope** you require:

    * **Everyone**: Select this option if all the users should have access to and be able to use this ERP connection. This means that they can use the price lists accessible via this connection.
    * **Specific users + groups**: Click **No users or groups are selected** to choose which users and/or user groups should have access to this ERP connection.

1. Under **Configuration fields** define the settings you require. The contents of this list vary depending on the type of Sync Connector you have chosen.

1. Type in a description of the ERP connection in the field at the bottom.

1. Click **Test ERP connection** to verify that the connection is working. If you get an error message, you must resolve the problem before continuing.

1. Click **OK**. The ERP connection is displayed in the **ERP connections** list.

    > [!NOTE]
    > The **OK** button is disabled until the ERP connection test succeeds.

You must check the **Active** column to activate the connection, so that the **ERP** tab is displayed in SuperOffice CRM. But before you activate the ERP connection, you must make sure it is configured correctly:

* Specify synchronization settings, and choose which fields should be shown in the search window and in the **ERP** tab. See [Configure field mapping][1] and [Configure list mapping][2].

* Define the required default values for fields which normally only have one relevant value, to save the user having to enter values in these fields. See [Configure default values for synchronization][3].

* Select the order of the ERP fields displayed in the ERP tab in SuperOffice CRM. See [Rank fields shown in the ERP tab][4].

* If you use several ERP connections, you can choose which connections should be prioritized when synchronizing. See [Set synchronization priority][5].

* [Import data from the ERP system][6]

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md
[2]: sync-configure-list-mapping.md
[3]: sync-configure-default-values.md
[4]: sync-rank-fields-shown-in-erp-tab.md
[5]: sync-set-sync-priority.md
[6]: ../../../../admin/import/learn/import-from-erp.md

<!-- Referenced images -->
