---
uid: help-en-sale-stage-add
title: Add a sale stage
description: Add a sale stage
keywords: add sale stage, new sale stage, Sale - Stage list, sale stage, stage, sale
author: Bergfrid Dias
date: 01.03.2025
version: 10.5
topic: howto
license: salesessentials
audience: settings
audience_tooltip: Settings and maintenance
language: en
---

# Sale stage

[!include[Must be admin](../../learn/includes/req-admin.md)]

The **Stage** field in the Sale card tracks the phase of a sale, such as "Open," "Sold," or "Lost." These stages are predefined in the **Sale - Stage** list, which you can manage in **Settings and maintenance** under **Lists**.

Stages can be linked to [sale types][1], specifying which stages are available for each type. If no sales guide is defined, the **Stage** field is still visible on the sale, allowing users to view and update the sale's current stage.

## Add a sale stage

1. Select <i class="ph ph-list-bullets" aria-hidden="true"></i> **Lists** in the Navigator.

1. Select **Sale - Stage** from the dropdown menu. The **Items** tab displays all existing stages.

1. Click **Add** to open the **Edit list item** dialog.

1. In the **Name** field, enter the name of the new stage. *(Mandatory)*

    This name will appear in the **Stage** field on the Sale screen.

1. In the **Probability** field, specify the likelihood of a successful sale at this stage, as a percentage.

    This figure will appear next to the stage in the Sale screen.

1. *(Optional)* Add a description in the **Description** field to clarify the purpose of the stage.

1. Click **Save** to apply your changes or **Cancel** to discard them.

## Edit or delete a sale stage

1. Follow steps 1–2 in **Add a sale stage** to access the **Sale - Stage** list.

1. To edit:
   1. Double-click the required stage to open the **Edit list item** dialog.
   1. Update the fields as needed and click **Save**.

1. To delete:
   1. Select the stage in the list and click **Delete**.

    > [!CAUTION]
    > Deleting a stage removes it from all linked sale types and sales guides. Ensure it is not in active use before proceeding.

## Restore a deleted sale stage

If a sale stage has been deleted, you can restore it from the **Sale - Stage** list. However, restoring does not automatically reestablish any links between the restored item and related sale types or guides. You must recreate these connections manually if needed.

The steps are similar to [restoring a deleted sale type][2].

## Related content

* [Add or update sale types][1]
* [Create a sales guide][3]
* [Edit a sales guide][4]
* [Track sales progress][5]

<!-- Referenced links -->
[1]: sale-type.md
[2]: sale-type.md#restore
[3]: create-sales-guide.md
[4]: edit-sales-guide.md
[5]: ../learn/sales-guides.md#change-stage
