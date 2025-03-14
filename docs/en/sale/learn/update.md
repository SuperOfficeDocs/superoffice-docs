---
uid: help-en-sale-update
title: Update a sale
description: How to update existing sale information, change its stage (including marking it as stalled, sold, or lost), or delete a sale if it is no longer relevant.
keywords: update sale, edit sale, delete sale, stalled, lost, sold, sale
author: Bergfrid Dias
date: 01.06.2025
version: 10.5
topic: howto
license: salesessentials
audience: person
audience_tooltip: SuperOffice CRM
language: en
---

# Update a sale

You can update existing sale information, change its stage (including marking it as stalled, sold, or lost), or delete a sale if it is no longer relevant.

## Edit sale

1. Open the **Sale** screen for the sale you want to update. See [Use the Find screen][5].

1. Click <i class="ph ph-pencil-simple" aria-hidden="true"></i> in the upper-right corner of the Sale card to enter edit mode.

1. Make the necessary changes. You can switch between tabs while remaining in edit mode.

    * **Total cost, Profit, and Percentage fields:** Changing one field will automatically update the others to ensure consistency.

    * **Changing the stage:** Updating the stage automatically adjusts the **Probability** field. You can still manually override this value if needed. If the sale type is linked to a [sales guide][1], the previous stages in the guide will be marked as completed with a tick.

    > [!CAUTION]
    > Switching **sale types** linked to a sales guide will remove the guide. Activities and documents remain in the **Activities** tab and will relink if you revert to the original type.

1. Click **Save** to apply changes, or click **Cancel** to discard them. Both actions will exit edit mode.

    > [!NOTE]
    > If the **Save** button appears dimmed, ensure all mandatory fields are filled in.

## <a id="stalled"></a>Mark a sale as stalled

This status can be used when, for example, a customer delays their purchasing decision until a later date, such as the following year

1. Check the **Stalled** box in the **Sale** screen.

1. Fill in the following additional fields:
    * **Re-open date:** The date when the sale should be revisited.
    * **Reason (stalled):** Explanation of why the sale cannot progress.

    ![Stalled sale -screenshot][img1]

1. Click **Save**. The **Follow-up** dialog opens, allowing you to schedule a future meeting or call to follow up on the stalled sale.

> [!NOTE]
> The **Re-open date** and **Reason** fields replace the **Next activity** field.

## Mark a sale as sold

1. In the **Stage** dropdown menu, select **Sold**.

1. Update the **Date** field (defaults to today's date) to the actual closing date, if different.

1. Select the **Reason** for the sale's success.

    ![Sold sale -screenshot][img2]

1. Adjust the sales **Amount** and update the financial details in the **Details** tab.

1. Click **Save**.

## Mark a sale as lost

1. In the **Stage** dropdown menu, select **Lost**.

1. Select the **Reason** for the sale's failure.

    ![Lost sale -screenshot][img3]

1. Update other fields if applicable.

1. Click **Save**.

If the sale has the status **Sold** or **Lost**, you can check the **Completed** box.

## <a id="delete"></a>Delete a sale

1. Open the **Sale** screen for the sale you want to delete.

1. Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) in the upper-right corner of the Sale card and select **Delete**.

1. In the **Delete sale** dialog, review the sale details to ensure you are deleting the correct sale. **This cannot be undone.**

    > [!NOTE]
    > If the **Delete** option is unavailable, you may lack sufficient permissions to delete the sale. You cannot delete sales that do not belong to you unless you have the necessary permissions.

1. Click **Yes** to confirm the deletion.

## Related content

* [Create a sale][2]
* [Sales guides][1]
* [Explanation of the fields][3]

<!-- Referenced links -->
[1]: sales-guides.md
[2]: create.md
[3]: create.md#fields
[5]: ../../search-options/learn/find-screen.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/sale/stalled-sale.png
[img2]: ../../../media/loc/en/sale/won-sale.png
[img3]: ../../../media/loc/en/sale/lost-sale.png
