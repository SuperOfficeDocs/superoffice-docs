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

To do this:

1. Go to the **Sync** tab in the **Quote/Sync** screen. The **ERP connections** list shows existing ERP connections.

2. Uncheck the **Active** box for the ERP connection you want to edit.

3. Select the ERP connection, and click the **List mapping** button at the bottom. The **List mapping** dialog displays the lists that are available for mapping. If no lists are displayed, you have not mapped any lists in [Configure field mapping](sync-configure-field-allocation.md).

4. Select a list on the left-hand side of the dialog. The available field items are displayed on the right-hand side of the dialog.

5. Select the corresponding CRM item for each ERP item.

    **Note**: Mapping is "one to one". You cannot map to the same CRM item twice. Double-mapped list items are displayed in RED. To leave an ERP list item unmapped, select **(No Selection)**.

6. Repeat steps 4 to 5 to map list items for the next list.

7. Check **Active** for the ERP connection you have edited.

## Related topics

[Configure field mapping](sync-configure-field-allocation.md)
