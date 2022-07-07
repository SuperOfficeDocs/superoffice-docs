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

To add an ERP connection:

Go to the **Sync** tab in the **Quote/Sync** screen.

Click **Add** at the bottom of the **ERP connections** list. The **Define new ERP connection** dialog appears.

Enter the name of the ERP connection in the **Name** field.

Selected the required **ERP Sync Connector** in the list. This list is identical to **Sync Connectors**.

Select the **Scope** you require:

* **Everyone**: Select this option if all the users are to have access to and be able to use this ERP connection. This means that they can use the price lists accessible via this connection.
* **Specific users + groups**: Click **No users or groups are selected** to choose which users and/or user groups should have access to this ERP connection.

Under **Configuration fields** define the settings you require. The contents of this list vary depending on the type of Sync Connector you have chosen.

Type in a description of the ERP connection in the field at the bottom.

Click **Test ERP connection** to verify that the connection is working. If you get an error message, you need to resolve the problem before continuing

Click **OK** when you have finished. The **OK** button is disabled until the ERP connection test has succeeded. The ERP connection is displayed in the **ERP connections** list.

You must check the **Active** column to activate the connection, so that the **ERP** tab is displayed in SuperOffice CRM. But before you activate the ERP connection, you must make sure it is configured correctly:

* Specify synchronisation settings, and choose which fields should be shown in the search window and in the **ERP** tab. See [Configure field mapping](sync-configure-field-allocation.md) and [Configure list mapping](sync-configure-list-mapping.md).
* Define the required default values for fields which normally only have one relevant value, to save the user having to enter values in these fields. See [Configure default values for synchronisation](sync-configure-default-values.md).
* Select the order of the ERP fields displayed in the ERP tab in SuperOffice CRM. See [Rank fields shown in the ERP tab](sync-rank-fields-shown-in-ERP-tab.md).
* If you use several ERP connections, you can choose which connections should be prioritised when synchronising. See [Set synchronisation priority](sync-set-sync-priority.md).
* [Import data from the ERP system](../import-web/import-from-ERP.md)
