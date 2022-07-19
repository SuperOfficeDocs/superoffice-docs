---
uid: help-en-sales-targets
title: Sales targets
description: Sales targets
author: SuperOffice RnD
so.date: 07.04.2022
keywords: Service
so.topic: help
language: en
---

# Sales targets

Set up sales targets to keep track of your budgets. Sales targets can be set up per year for your organization, groups/teams and users, with monthly or quarterly intervals. In the dashboard you can add custom tiles to view budgets and actual sales in the same diagram.

## Before you start

Before you start using the sales targets feature, you must set up a few things in SuperOffice Settings and Maintenance:

* By default the sales targets are divided into months, but you can change this to quarterly targets. In SuperOffice Settings and Maintenance, go to **Preferences** &gt; **Global system preferences** &gt; **Targets** to make any changes.

* Locking and unlocking sales targets are only available to users with the functional right called **Can lock and unlock targets**. This can be changed in **Roles** in SuperOffice Settings and Maintenance.

* Creating, editing and deleting sales targets requires specific data rights. This can be changed in **Roles** in SuperOffice Settings and Maintenance.

> [!TIP]
> Use the **Freetext search** field to find sales targets for specific groups and users in a specific year. See [Freetext search](../key-functions/Freetext-search.md).

## Add sales targets for a year

To do this:

1. Click ![icon][img1] **Main menu** and select **Targets**. The **Sales targets** screen opens. If no sales targets have been created yet, the list is empty.
2. In the **Select year** list, select the year for which you want to create a sales target. Your can also set up targets for previous years, to create budget statistics back in time.
3. Click **Add groups and users** and select a company or group/team. Use the search field to find specific groups.
4. Click the company or group in the list. The selected company or group is added to the overview with monthly/quarterly targets set to 0 in the default currency. All users (primary group members) belonging to a group are listed below the group.
5. Use the expand/collapse buttons at the top or the arrows next to each group to show or hide users.
6. If applicable, change the currency for the company or group. The default currency is the base currency set for you company. You cannot set currency for individual users.
7. Adjust the numbers manually using the **TAB** key go the next field.  
    or  
    Click the menu button ( ![icon](../media/salestarget-menu.png) ) at the end of a row and select **Adjust numbers**. The following options are available in the dialog:
    * **Set initial amount**: Enter the amount for the whole year. The amount will be split equally among the months or quarters on the current row.
    * **Copy from**: Copy the values from another group or user.
    * **Copy from last year**: Copy values from last year and increase the values by a specific percentage. This option is disabled if last year has no values.  
        Click **Save** when you are done. The sums for all users will be added to the **All** row at the top of the list of users.
8. Optional: When you have completed a row, you can lock it (![icon](../media/salestarget-unlocked.png)-![icon](../media/salestarget-locked.png)) to disable editing. This can be relevant when the budget has been approved and should not be edited. Locked rows cannot be removed, cleared or edited.
9. If a specific group or user should not have a sales target, click the menu button ( ![icon](../media/salestarget-menu.png) ) and select **Clear** to empty the values.
10. Click **Save**.
11. Repeat steps 3-10 to add additional groups or companies.
12. Go to step 2 to add sales targets for another year, or click **Save and close** to exit this screen.

> [!NOTE]
> To remove a company or group target, click the menu button ( ![icon](../media/salestarget-menu.png) ) and select **Remove company target** or **Remove group target**.

## Revision history

To view the revision history for a sales target (row), click the menu button ( ![icon](../media/salestarget-menu.png) ) and select **Revision history**. In the screen that displays, you can view all changes that has been made to the current sales target. This includes changed values and locking/unlocking, when the change was made and by whom. Use the expand/collapse buttons at the top to view/hide details.

## Export

Click the **Task** button to export the sales target for the selected year to Excel or PDF.

## Related topics

* [Dashboard][1]
* [Using sales targets in tiles][2]

<!-- Referenced links -->
[1]: ../../dashboard/index.md
[2]: ../../dashboard/dashboard-tiles-sales-targets.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/globalmenu-mainmenu-small.png