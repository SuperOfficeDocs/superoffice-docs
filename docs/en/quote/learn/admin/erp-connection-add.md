---
uid: help-en-erp-connection-add
title: ERP connection add
description: ERP connection add
author: SuperOffice RnD
date: 06.29.2022
keywords: quote, ERP, connector
topic: howto
language: en
---

# Add ERP connection (Quote Connector)

Each Quote Connector must have an ERP connection with configuration data for linking the Quote Connector with SuperOffice.

How do I set up an ERP connection for SuperOffice CRM for Web (Online)?

1. Go to [https://online.superoffice.com/appstore][4].
2. Locate the correct &quot;sync&quot; app for your ERP system. [Click here to search][2]
3. Locate the correct &quot;quote&quot; app for your ERP system. [Click here to search][3]
4. To complete the setup, contact the app provider.

## To add an ERP connection

1. Go to the **ERP connections** tab in the Quote/Sync screen.

1. Click **Add** at the bottom of the **ERP connections** list. The **Define new ERP connection** dialog appears.

1. Enter the name of the ERP connection in the **Name** field.

1. Selected the required **Quote Connector** in the list. This list is identical to **Available Quote Connectors**.

1. Select a **Scope**:

    * **All**: Select this option if all the users are to have access to and be allowed to use this ERP connection. This means that they can use the price lists accessible via this connection.
    * **Specific users + groups**: Click **Select users and groups** to choose which user groups and/or users should have access to this ERP connection.

1. Select the ERP connection to handle the synchronization in the **ERP connection** field.

1. At the bottom of the dialog, configure the required settings. The contents of this list vary depending on the type of Quote Connector you have chosen.

1. Type in a description of the ERP connection in the field at the bottom.

1. Click **Test ERP connection** to verify that the connection is working.

1. Click **OK**.

## Delete and restore

At the bottom of the **ERP connections** list, you can delete ERP connections that are no longer in use.

To restore a deleted ERP connection:

1. Check **Deleted**.
1. Select the deleted connection in the list.
1. Click **Restore**.

<!-- Referenced links -->
[4]: https://online.superoffice.com/appstore
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote

<!-- Referenced images -->
