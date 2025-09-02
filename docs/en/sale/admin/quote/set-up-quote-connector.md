---
uid: help-en-quote-connector-setup
title: Set up ERP connection for quote connector
description: Learn how to configure a quote connector and create ERP connections to enable product and price integration in SuperOffice CRM.
keywords: set up quote connector, add quote connector, add ERP connection, test ERP connection, ERP connection, quote connection, quote connector, connector, quote
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: /en/quote/learn/admin/erp-connection-add
---

# Set up ERP connection for quote connector

To enable quoting in SuperOffice CRM, you must create an **ERP connection** using an available **quote connector**. The ERP connection determines where product data and pricing logic come from—either from an external ERP system or from SuperOffice's built-in product register.

## 1. Get the quote connector app

Before you can use a quote connector, you must install the correct app for your ERP system.

1. Go to the [SuperOffice App Store][4].

2. Search for a quote connector that supports your ERP system.

    * [Quote connector apps][3]
    * [Sync apps (optional)][2]

3. Follow the provider's instructions to install the app.

4. To complete the setup, contact the app provider if required.

## 2. Add an ERP connection

Once the connector is available, you must configure an ERP connection to activate it.

1. In Settings and maintenance, select <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Quote/Sync** in the navigator.

1. Go to the **ERP connections** tab.

1. Click **Add**. The **Define new ERP connection** dialog opens.

    ![Define ERP connection dialog -screenshot][img1]

1. Fill in the required fields:

    * **Name:** Internal name for this connection
    * **Quote Connector:** Select the connector to use
    * **Scope:** Choose who can use this connection (and its price list):
      * **All:** Available to all users
      * **Specific users and groups:** Click to select access
    * **ERP connection:** (If applicable) select an ERP connection from the sync connector for this system
    * **Configuration fields:** These vary by connector and may include:
      * Authentication credentials
      * Server or endpoint info
      * Business rules like rounding, discount validation, or fallback logic

1. Optionally, enter a **description** to clarify the connection's purpose.

1. Click **Test ERP connection** to verify that it works.

    > [!NOTE]
    > The test must succeed before you can save.

1. Click **OK** to save the ERP connection.

The new connection now appears in the list and is ready for use in quoting.

## Delete or restore ERP connections

To delete an ERP connection:

1. Select it in the list and click **Delete**.

To restore a deleted connection:

1. Check **Deleted** to show removed connections.
1. Select the one you want to restore.
1. Click **Restore**.

<!-- Referenced links -->
[2]: https://online.superoffice.com/appstore/app/search?phrase=sync
[3]: https://online.superoffice.com/appstore/app/search?phrase=quote
[4]: https://online.superoffice.com/appstore

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/sale/quote-erp-connection.png
