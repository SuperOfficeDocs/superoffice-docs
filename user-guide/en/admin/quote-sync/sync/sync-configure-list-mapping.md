---
uid: help-en-sync-configure-list-mapping
title: sync configure list mapping
description: sync configure list mapping
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance
so.topic: help
language: en
---

# Configure list mapping

When synchronising data between SuperOffice and ERP systems, you have to specify which SuperOffice field and which ERP field belong together.

> [!NOTE]
> When editing an ERP connection, you first need to deactivate it.

[!include[To do this](../../../includes/to-do-this.md)]

[!include[Go to sync](../includes/goto-sync.md)]

1. Select the ERP connection, and click the **List mapping** button at the bottom. The **List mapping** dialog displays the lists that are available for mapping. If no lists are displayed, you have not mapped any lists in [Configure field mapping][1].

1. Select a list on the left-hand side of the dialog. The available field items are displayed on the right-hand side of the dialog.

1. Select the corresponding CRM item for each ERP item.

    > [!NOTE]
    > Mapping is "one to one". You cannot map to the same CRM item twice. Double-mapped list items are displayed in RED. To leave an ERP list item unmapped, select **(No Selection)**.

1. Repeat steps 4 to 5 to map list items for the next list.

1. Check **Active** for the ERP connection you have edited.

## Related topics

* [Configure field mapping][1]

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md

<!-- Referenced images -->
