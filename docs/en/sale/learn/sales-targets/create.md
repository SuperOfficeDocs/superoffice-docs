---
uid: help-en-sales-targets-create
title: Set up sales targets
description: Keep track of your budgets by setting up sales targets. This will help you to set the right expectations, plan your growth, increase motivation and save time.
author: SuperOffice RnD
date: 02.16.2023
keywords: sale
topic: howto
language: en
---

# Set up sales targets

Keep track of your budgets by setting up sales targets. This will help you to set the right expectations, plan your growth, increase motivation and save time.

![The Targets dialog gives you an overview of your current and previous sales targets -screenshot][img5]

The target list can contain of the following sections:

* The company's target
* The user group's target
* The user's target
* The sum of targets for all users in one user group (not editable)

It is optional to add the company target and to have user specific targets (go to Target settings to change). The sum of all targets in one user group is not editable. It shows the sum for all the users in one user group and is a guideline to make it easier to set up the target for the whole user group. You can add and edit the company target, because the target for the whole company is not necessarily the same as the sum of all user groups.

## Requirements

> [!NOTE]
> **ONLINE** customers only. (Not available to Onsite customers.)

### Licenses

This feature requires the Sales Premium licence.
The following functions are only available with the Sales Targets Unlimited licence in addition to the Sales Premium licence:

* Adding additional target types (dimensions)
* Creating targets for multiple groups/teams

### Access

Access to the **Targets** feature is set by your administrator in Settings and maintenance.

### Data rights

To access this feature, you need data rights for **Target**.

### Functional rights

Only users with the functional right **Can lock and unlock targets** can lock and unlock targets.

## Before you start

Before you start using the sales targets feature, you must set up a few things in Settings and maintenance:

* By default the sales targets are divided into months, but you can change this to quarterly targets. In Settings and maintenance, go to **Preferences** > **Global system preferences** > **Targets** to make any changes.

* Locking and unlocking sales targets are only available to users with the functional right called **Can lock and unlock targets**. This can be changed in **Roles** in Settings and maintenance.

* Creating, editing and deleting sales targets requires specific data rights. This can be changed in **Roles** in Settings and maintenance.

> [!TIP]
> Use the **Free-text search** field to find sales targets for specific groups and users in a specific year.

## Add targets for a year

> [!TIP]
> The default target type is **All sales - Amount**. If you have the Sales Targets Unlimited licence, you can create additional target types.

1. Click **Main menu** (<i class="ph ph-list" aria-hidden="true"></i>) and select **Targets**. If no sales targets have been created yet, the list is empty.

2. In the **Sales targets** screen, select the year that you want to create a sales target for from the **Select year** list. Your can also set up targets for previous years, to create budget statistics back in time.

    > [!NOTE]
    > If you have selected a year AND the previous year contains sales targets, you will be asked if you want to create targets based on the previous year. You can copy the targets as is, or select to increase the targets by a given percentage.

3. Click **Add groups and users**. Use the search field to find specific groups.

4. Click the relevant group in the list. If you want to add a target for the whole company, select **Company target**. The selected group is added to the overview with monthly/quarterly targets set to 0 in the default currency (unless you have copied the numbers from another year). All users (primary group members) belonging to a group are listed below the group.

5. Use the expand/collapse buttons at the top or the arrows next to each group to show or hide users.

6. If applicable, change the currency for the company or group. The default currency is the base currency set for you company. You cannot set currency for individual users.

7. Adjust the numbers manually using the **TAB** key go the next field. You can also [copy and paste numbers from Excel](#import) or click <i class="ph ph-list" aria-label="Menu icon"></i> at the end of a row and select **Adjust numbers**. Options:

    * **Set initial amount**: Enter the amount for the whole year. The amount is split equally among the months or quarters on the current row.
    * **Copy from**: Copy the values from another group or user.
    * **Copy from last year**: Copy values from last year and increase the values by a specific percentage. This option is disabled if last year has no values.
        Click **Save** when you are done. The sums for all users are added to the **All** row at the top of the list of users.

8. Optional: When you have completed a row, you can lock it (<i class="ph ph-lock-simple" aria-hidden="true"></i>) to disable editing. For example, after a budget is approved and should not be edited. Locked rows cannot be removed, cleared or edited.

9. If a specific group or user should not have a sales target, click <i class="ph ph-list" aria-label="Menu icon"></i> and select **Clear** to empty the values.

10. Click **Save**.

11. Repeat steps 3-10 to add additional groups or companies. This requires the Sales Targets Unlimited licence.

12. Go to step 2 to add sales targets for another year, or click **Save and close** to exit this screen.

> [!NOTE]
> To remove a company or group target, click <i class="ph ph-list" aria-label="Menu icon"></i> and select **Remove company target** or **Remove group target**.

## Lock/unlock function

Depending on your user role (the "Can lock/unlock targets" functional right), you can lock and unlock a sales target. When the sales target is approved, you can select the row to lock it, and then the row will be disabled for editing. If the sales target was approved and locked, it should not be unlocked unless there are certain reasons to modify it.

## Copy numbers from another user's target

To avoid having to set up the sales targets from scratch again for a different user, you can copy another user's sales target as they are (fixed numbers), adjust the target up or down with % or set the initial annual amount.

![Adjust numbers for a specific user, user group or the company target -screenshot][img6]

If you have added some numbers that are not correct, or a user has quit the company, you can select to clear the numbers added. Notice that you cannot delete a user in a user group if the user does not have any sales targets, but you can clear the row.

> [!TIP]
> You can export the whole target list, edit it in a spreadsheet and then import it back into Targets.

## Export

Click the **Task** button (<i class="ph ph-dots-three-circle-vertical" aria-hidden="true"></i>) to export the sales target for the selected year to Excel or PDF.

## <a id="import"></a>Import

You can copy target data from Excel and paste the data into the table in SuperOffice.

To do this:

1. Click the **Task** button to export the sales target for the selected year to Excel.

2. Edit the target data (amounts) in the spreadsheet.

3. Copy the target data in the spreadsheet (amounts only). You can select any area.

4. Select the upper-left cell in the relevant area in SuperOffice and paste the data. If some of the rows are locked, you will be unable to paste the data.

## Revision history

To view the revision history for a sales target (row), click <i class="ph ph-list" aria-label="Menu icon"></i> and select **Revision history**. In the screen that displays, you can view all changes to the current sales target. This includes changed values and locking/unlocking, when the change was made and by whom. Use the expand/collapse buttons at the top to view/hide details.

## Related topics

* [Dashboard][1]
* [Using sales targets in tiles][2]

<!-- Referenced links -->
[1]: ../../../dashboard/learn/index.md
[2]: ../../../dashboard/learn/show-sales-targets.md

<!-- Referenced images -->
[img5]: ../../../../media/loc/en/sale/user-targets-salestargets.png
[img6]: ../../../../media/loc/en/sale/user-targets-salestargets-adjustnumbers.png
