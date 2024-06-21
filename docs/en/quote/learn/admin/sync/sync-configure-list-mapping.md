---
uid: help-en-sync-configure-list-mapping
title: Configure list mapping
description: Configure list mapping
author: Bergfrid Dias
date: 03.29.2023
keywords: quote, sync, connector, ERP, mapping
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Configure list mapping

When synchronizing data between SuperOffice and ERP systems, you must specify which SuperOffice field and which ERP field belong together.

> [!NOTE]
> When editing an ERP connection, you must first deactivate it.

1. [!include[Go to sync](../includes/goto-sync.md)]

1. Select the ERP connection, and click the **List mapping** button at the bottom.

1. Select a list. The available field items are displayed on the right side of the dialog.

    If no lists are displayed, you must [configure field mapping][1].

1. Select the corresponding CRM item for each ERP item.

    > [!NOTE]
    > Mapping is one-to-one. You cannot map to the same CRM item twice. Double-mapped list items are displayed in RED. To leave an ERP list item unmapped, select **(No Selection)**.

1. Repeat steps 4 to 5 to map list items for the next list.

1. Check **Active** for the ERP connection you edited.

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md

<!-- Referenced images -->
