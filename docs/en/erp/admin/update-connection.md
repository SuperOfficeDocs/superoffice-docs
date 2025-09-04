---
uid: help-en-erp-update-connection
title: Edit ERP connection
description: Learn how to change the name, scope, or configuration of an existing ERP connection in SuperOffice CRM.
keywords: edit ERP connection, update ERP connection, change ERP settings, sync connector, ERP config, SuperOffice sync
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Settings and maintenance
language: en
index: true
redirect_from: /en/quote/learn/admin/sync/sync-edit-erp-connection
---

# Edit ERP connection

You can update the name, scope, or configuration values for an existing ERP connection.

> [!NOTE]
> If the connection is active (checkmark in the **Active** column), you must temporarily deactivate it before updating configuration fields. Remember to reactivate the connection after configuration.

## Steps

1. In Settings and maintenance, select <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Quote/Sync** in the navigator and go to the **Sync** tab.

1. Select the ERP connection and click **Configure ERP connection**.

1. In the dialog, update the name or scope as needed.

1. To update connector-specific configuration fields:

    1. Clear the **Active** checkbox.
    1. Update fields as needed.
    1. Select **Active**.
    1. Click **Test ERP connection** and fix any errors.

1. Click **OK** to save and close the dialog.

1. If you need to change field mappings, default values, or list mappings, do so now using the buttons in lower-left corner. For detailed instructions, see [Configure ERP connection][1].

## Troubleshooting

### ERP connection cannot be saved

If the **OK** button is dimmed when adding or editing a connection:

* Make sure the connection test has succeeded.
* Check that all required configuration fields are filled in.
* Confirm that any mandatory settings (such as scope) are completed.

## Related content

* [Add a sync connector and ERP connection][2]
* [Connect companies, contacts, and projects to ERP actors][3]

<!-- Referenced links -->
[1]: configure.md
[2]: add-connection.md
[3]: ../learn/connect.md
