---
uid: help-en-sales-targets
title: Sales targets
description: Sales targets
author: SuperOffice RnD
so.date: 07.04.2022
keywords: Service
so.topic: help, online
language: en
---

# Targets

> [!NOTE]
> **Licenses**
> This feature requires the Sales Premium licence for **ONLINE** customers. (Not available for Onsite customers.)
> The following functions are only available with the Sales Targets Unlimited licence in addition to the Sales Premium licence:
>
> * Adding additional target types (dimensions)
> * Creating targets for multiple groups/teams
>
> **Access**
> Access to the **Targets** feature is set by your administrator in SuperOffice Settings and maintenance.
>
> **Data rights**
> To access this feature, you need data rights for **Target**.
>
> **Functional rights**
>
> Only users with the functional right **Can lock and unlock targets** can lock and unlock targets.

Set up sales targets to keep track of your budgets. Sales targets can be set up per year for your organization, groups/teams and users, with monthly or quarterly intervals. In the dashboard you can add custom tiles to view budgets and actual sales in the same diagram.

## Before you start

Before you start using the sales targets feature, you must set up a few things in SuperOffice Settings and Maintenance:

* By default the sales targets are divided into months, but you can change this to quarterly targets. In SuperOffice Settings and Maintenance, go to **Preferences** > **Global system preferences** > **Targets** to make any changes.

* Locking and unlocking sales targets are only available to users with the functional right called **Can lock and unlock targets**. This can be changed in **Roles** in SuperOffice Settings and Maintenance.

* Creating, editing and deleting sales targets requires specific data rights. This can be changed in **Roles** in SuperOffice Settings and Maintenance.

> [!TIP]
> Use the **Freetext search** field to find sales targets for specific groups and users in a specific year. See [Freetext search][3].

## Add targets for a year

> [!TIP]
> The default target type is **All sales - Amount**. If you have the Sales Targets Unlimited licence, you can create additional target types.

1. Click ![icon][img1] **Main menu** and select **Targets**. If no sales targets have been created yet, the list is empty.

2. In the **Sales targets** screen, select the year that you want to create a sales target for from the **Select year** list. Your can also set up targets for previous years, to create budget statistics back in time.

    > [!NOTE]
    > If you have selected a year AND the previous year contains sales targets, you will be asked if you want to create targets based on the previous year. You can copy the targets as is, or select to increase the targets by a given percentage.

3. Click **Add groups and users**. Use the search field to find specific groups.

4. Click the relevant group in the list. If you want to add a target for the whole company, select **Company target**. The selected group is added to the overview with monthly/quarterly targets set to 0 in the default currency (unless you have copied the numbers from another year). All users (primary group members) belonging to a group are listed below the group.

5. Use the expand/collapse buttons at the top or the arrows next to each group to show or hide users.

6. If applicable, change the currency for the company or group. The default currency is the base currency set for you company. You cannot set currency for individual users.

7. Adjust the numbers manually using the **TAB** key go the next field. You can also copy and paste numbers from Excel. See the [Import](#import) section below.
    or
    Click the menu button ![icon][img2] at the end of a row and select **Adjust numbers**. The following options are available in the dialog:

    * **Set initial amount**: Enter the amount for the whole year. The amount is split equally among the months or quarters on the current row.
    * **Copy from**: Copy the values from another group or user.
    * **Copy from last year**: Copy values from last year and increase the values by a specific percentage. This option is disabled if last year has no values.
        Click **Save** when you are done. The sums for all users are added to the **All** row at the top of the list of users.

8. Optional: When you have completed a row, you can lock it ![icon][img3]-![icon][img4] to disable editing. For example, after a budget is approved and should not be edited. Locked rows cannot be removed, cleared or edited.

9. If a specific group or user should not have a sales target, click the menu button ![icon][img2] and select **Clear** to empty the values.

10. Click **Save**.

11. Repeat steps 3-10 to add additional groups or companies. This requires the Sales Targets Unlimited licence.

12. Go to step 2 to add sales targets for another year, or click **Save and close** to exit this screen.

> [!NOTE]
> To remove a company or group target, click the menu button ![icon][img2] and select **Remove company target** or **Remove group target**.

## Add target type

> [!NOTE]
> This function requires the Sales Targets Unlimited licence.

You can add new target types (dimensions) in addition to the default target type **All sales - Amount**.

1. Click **Add new target type**. Or click ![icon][img5] (**Configure target**) on the tab to edit an existing target type.

2. Click **Target type** to select the target type (dimension) you want to use.

3. Click **Measurement unit** to select the relevant unit. The available units will depend on the selected target type. If you selected **Category** as target type, you can for instance select to measure by amount or count (number of sales in a category).

4. In the next list, you can select specific elements of the target type you have selected. If you do not select any, all will be included. Example: If you selected **Category** as target type, you can select the company categories for which you want to create targets.

5. Select **Available on company level and group level only** if this target type should not be available on a user level, only for group/team level and company level.

6. Click **Save**. The new target type is added as a tab. You can now add targets as described above.

> [!NOTE]
> If you want to edit an existing target type, please note that target type and measurement unit cannot be changed. You can alternatively create a new target type with the required settings, and then delete the old one.

## Revision history

To view the revision history for a sales target (row), click the menu button ![icon][img2] and select **Revision history**. In the screen that displays, you can view all changes to the current sales target. This includes changed values and locking/unlocking, when the change was made and by whom. Use the expand/collapse buttons at the top to view/hide details.

## Export

Click the **Task** button to export the sales target for the selected year to Excel or PDF.

## Import

You can copy target data from Excel and paste the data into the table in SuperOffice.

To do this:

1. Click the **Task** button to export the sales target for the selected year to Excel.

2. Edit the target data (amounts) in the spreadsheet.

3. Copy the target data in the spreadsheet (amounts only). You can select any area.

4. Select the top left cell in the relevant area in SuperOffice and paste the data. If some of the rows are locked, you will be unable to paste the data.

## Related topics

* [Dashboard][1]
* [Using sales targets in tiles][2]

<!-- Referenced links -->
[1]: ../../dashboard/learn/index.md
[2]: ../../dashboard/learn/show-sales-targets.md
[3]: ../../search-options/learn/freetext-search.md

<!-- Referenced images -->
[img1]: ../../../media/icons/main-menu-small.png
[img2]: ../../../../common/icons/context-menu.png
[img3]: ../../../../common/icons/lock-on.png
[img4]: ../../../../common/icons/lock-off.png
[img5]: ../../../../common/icons/cog-wheel.png
