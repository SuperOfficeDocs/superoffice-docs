---
uid: help-en-erp-connection-add
title: ERP connection add
description: ERP connection add
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Add ERP connection (Quote Connector)

Each Quote Connector must have an ERP connection with configuration data for linking the Quote Connector with SuperOffice.

[!include[How to set up ERP](../includes/set-up-erp-web.md)]

To add an ERP connection:

Go to the **ERP connections** tab in the **Quote/Sync** screen.

Click **Add** at the bottom of the **ERP connections** list. The **Define new ERP connection** dialog appears.

Enter the name of the ERP connection in the **Name** field.

Selected the required **Quote Connector** in the list. This list is identical to **Available Quote Connectors**.

Select the **Scope** you require:

* **All**: Select this option if all the users are to have access to and be allowed to use this ERP connection. This means that they can use the price lists accessible via this connection.
* **Specific users + groups**: Click **Select users and groups** to choose which user groups and/or users should have access to this ERP connection.

Select the ERP connection to handle the synchronisation ([Sync Connector][1]) in the **ERP connection** field.

At the bottom of the dialog, configure the required settings. The contents of this list vary depending on the type of Quote Connector you have chosen.

Type in a description of the ERP connection in the field at the bottom.

Click **Test ERP connection** to verify that the connection is working.

Click **OK** when you have finished.

At the bottom of the **ERP connections** list, you can delete ERP connections that are no longer in use, for example. If you want to restore a deleted ERP connection, you can check **Deleted**, select the deleted connection in the list, and then click **Restore**.

<!-- Referenced links -->
[1]: quotesync-tab-sync.md

<!-- Referenced images -->
