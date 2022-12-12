---
uid: help-en-users-associates-tab
title: Associates tab
description: Associates tab in the Users screen
author: SuperOffice RnD
so.date: 06.29.2022
keywords: user, associate
so.topic: reference
language: en
---

# The associate list

By default, the list in the **Associates** tab consists of the following columns:

| Column | Description |
|---|---|
| User ID | The user name assigned to the associate. |
| First name | The user’s first name. |
| Last name | The user’s last name. |
| Primary group | The primary group of the user. |
| Role | The [role][7] assigned to the user. The role determines the user's access rights to data in SuperOffice CRM. |
| User plan | The user plan assigned to the user, |
| Owning company | The name of the organization the user belongs to (defined as database owner). |

> [!TIP]
> You can select which columns to display in the list. Just right-click a column heading, and select the relevant columns in the columns list. To change the order of the columns, click and drag a column heading.

## User information

On the right-hand side of the window, there is detailed information about the user selected in the list of associates.

The full name, email address and owning company is displayed at the top. At the bottom of this section, you can activate/deactivate the user in SuperOffice using the **Can log in** button. Click the **Task** button to access functions such as **Move user** and for sending welcome emails and emails for resetting passwords.

* In the **Detail** tab you can [edit user information][2] such as user name, role, user plan and groups.
* In the **Licences** tab, you can select licenses in addition to those defined by the selected user plan.

## Filter and group users

If the list in the **Associates** tab contains many users, you can filter and group the list to make it more manageable.

The various options are described below.

### Search for users

Use this dynamic search function to quickly locate specific users by name or user ID, or to find all users belonging to specific roles, groups or user plans. Simply enter text in the search field to update the list with matching users.

### Show only users that can log in

Select this option to show only users that are active (have not been deactivated).

### <a id="filter" />Filtering the list

You can filter the list of users by any of the column headers.

> [!NOTE]
> Right-click a column to add any additional columns you want to filter by.

1. Go to the **Associates** tab.
2. Right-click a column heading or click ![icon][img1] in the top-right corner of the list.
3. Select **Enable filter**.
4. Click **OK**.Filter buttons (![icon][img2]) are added to each column header.
5. Click ![icon][img2] on the column you want to filter.
6. Select the relevant values in the list. Use the search function if the list is long.
7. Click **Filter**.
8. Repeat steps 5-7 to filter on additional columns.

### <a id="group" />Grouping the list

You can group the list of users by role, user plan, primary group, and similar. In addition, you can group on multiple levels.

> [!NOTE]
> Right-click a column to add any additional columns you want to group by (see also [Adjust views][6]).

1. Go to the **Associates** tab.
2. Right-click a column heading or click ![icon][img1] in the top-right corner of the list.
3. Select **Enable grouping**.
4. Click **OK**.
5. Click the column header for the value by which you want to group and drag it to the area above the columns ("Drag a column header and ..."). The list is now grouped by that value.
6. To group by additional values, click and drag another column header to the same area.
7. Click and drag the group values to change the order of the grouping levels.
8. Click a group value to change the sort order.

> [!NOTE]
> If you navigate to another tab, the grouping is reset.

## What would you like to do now?

* [Add users][2]
* [Move users][3]
* [Delete users][1]
* [Import users][4]
* [Log users off][5]

<!-- Referenced links -->
[1]: ../delete-user.md
[2]: ../add-associate.md
[3]: ../move-user.md
[4]: ../import-users.md
[5]: ../../win-client/logging-users-off.md
[6]: ../../howto/adjusting-views.md
[7]: ../role/index.md

<!-- Referenced images -->
[img1]: ../../../../common/icons/cog-wheel.png
[img2]: ../../../media/icons/column-header-filter.png
