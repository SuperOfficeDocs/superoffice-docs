---
uid: help-en-users
title: Users
description: Learn how to add new users, how to assign the right user roles and groups, and help the users with setup and WebTools.
keywords: Users screen, user, associate, our companies, visibility, visible for, available
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
index: true
redirect_from: 
  - /en/admin/user-management/learn/index
  - /en/admin/user-management/learn/screen/index
  - /en/admin/user-management/learn/visibility
  - /en/admin/user-management/learn/associates-filter-group
language: en
---

# Users

As an administrator you are in charge of adding and managing your users.

SuperOffice CRM uses a role- and group-based access right system. It means that **every SuperOffice user has a role and belongs to a primary group** (these are mandatory settings).

The following diagram shows a model of how the access right system works in SuperOffice CRM.

![Diagram showing the access right system][img1]

A [role][6] has a set of data and [functional rights][7], and a group setting grants access to data objects, various SuperOffice lists, and helps to set system preferences more efficiently.

The system allows you to configure access to companies, contacts, projects, project members, selections, sales, stakeholders (of sales), follow-ups, documents (including emails and mailings), relations (contact and company), and dashboards. All these different types of records are called **data objects**.

Each data object belongs to a user who might be you yourself (a), users in your primary group (b), users that belong to your other groups (c), other associates to whom you are not connected by any of your groups (d), external users (e), and anonymous users (f).

![The Roles - Associates screen, data rights tab -screenshot][img2]

The ownership of different data objects is set in different fields. For example, in the Company card the field called **Our Contact** specifies the owner of the record. For follow-ups, it is the field **Owner**, in the project **Responsible**, and so on.

## <a id="visible"></a>Visibility

If you can view specific documents, sales, follow-ups and selections does not depend solely on the role you are assigned. Certain individual items of information may not be available to you. In the documents and follow-ups dialogs and in the Sale and Selection screens, there is a list box called **Visible for**. In the Sale screen, you can, for example, choose to make the sale visible to everyone, visible only to the primary group that the owner belongs to, or visible only to the owner.

This requires the license **Confidential activities**.

To set this license, find the wanted user, click the **Licences** tab and then mark the **Confidential activities** checkbox.

## User types

* **Associates**: SuperOffice CRM users (in your company)

* **Other users**: Anonymous users and system users (onsite only)

* **Anonymous users**: Users with limited rights defined by the [role for anonymous users][4]. Anonymous users can be used, for instance, to provide access to web pages. In this way, salespersons can make relevant information from SuperOffice CRM available on a website that does not require a login, to give customers easy access to it.

* **System users**: The system user is intended for integration and can be used to allow processes full access to the SuperOffice database for replicating diaries, for example.

## Associates

**Associates** are SuperOffice users in your company (or a related company such as a subsidiary).

In the **Associates** tab in the Users screen, you can add users of the type **Associate**, and assign them roles, groups and licenses, edit existing users and delete users.

For a person to be registered as a SuperOffice CRM user, this person must be registered with a company displayed in the **Company** list box in the Users screen. And for a company to be displayed in the **Company** list box in the Users screen, the company must appear on the company list in the **Our companies** tab.

> [!NOTE]
> In the Users screen you specify which licenses you want different users to have. To add new system licenses or increase/reduce the number of licenses for one or more modules, contact SuperOffice to [update the license information][16].

## User groups

A **group** is assigned to the user and grants access to data objects (4 in the previous diagram). A user must have one **primary group** and can have multiple **other groups**.

![Group membership diagram][img5]

In this example, user A has Marketing as the other group and user B has Marketing as the primary group. In this case, if User A wants to see data created by User B, User's A role has to have the right "Read" next to all data objects in the column *Other group*. It is because Marketing group is other group for user A and it is connecting them with records that user B creates.

A group also can grant access to list items (5 in the diagram) in SuperOffice CRM. This is relevant only if you use the **Grouping and filtering** setting (a) on your lists. If this setting is not set up, all users will have access to all lists in SuperOffice CRM. Grouping and filtering are especially useful when many users with various responsibilities can access the system. This way you can avoid certain users accessing the information that they are not supposed to see.

![Grouping and filtering by user group for document template list -screenshot][img6]

For example, if you want to make a particular list item visible only to some users, you need to go to the list, which stores these items (a), select the item (b) and in the box called "Visible for user groups", add a check next to the user groups which should see the list item (c).

![Select preference level group for follow-up -screenshot][img7]

Having your users organized in groups is also convenient when you want to personalize SuperOffice settings, we call them [preferences][15] (6). Every preference can be set for one user, user group, or the entire system.

![Preferences for Sales group -screenshot][img8]

## <a id="screen"></a>Users screen

In the Users screen, you can add and edit different types of users.

![An overview of the User screen in Settings and maintenance -screenshot][img3]

[**Our companies:**][2] For a person to be registered as a SuperOffice CRM user, this person must be registered with a company displayed in the **Company** list in the Users screen. And for a company to be displayed in the **Company** list in the Users screen, the company must appear on the company list in the **Our companies** tab.

> [!NOTE]
> Changes you make in the Users screen do not come into effect until you click **Save** at the bottom of the screen, and confirm that you want to save the changes in the dialog that then appears. If you click **Cancel**, you will lose all changes you have made in this screen  your last save.

### <a id="associates"></a>The associate list

By default, the list in the **Associates** tab consists of the following columns:

| Column | Description |
|---|---|
| User ID | The user name assigned to the associate. |
| First name | The user's first name. |
| Last name | The user's last name. |
| Primary group | The primary group of the user. |
| Role | The [role][6] assigned to the user. The role determines the user's access rights to data in SuperOffice CRM. |
| User plan | The user plan assigned to the user. |
| Owning company | The name of the organization the user belongs to (defined as database owner). |

> [!TIP]
> You can select which columns to display in the list. Just right-click a column heading, and select the relevant columns in the columns list. To change the order of the columns, click and drag a column heading.

* **Search for users:** Use this dynamic search function to quickly locate specific users by name or user ID, or to find all users belonging to specific roles, groups or user plans. Simply enter text in the search field to update the list with matching users.

* **Show only users that can log in:** Select this option to show only users that are active (have not been deactivated).

#### Filtering the list <i class="ph ph-funnel" aria-hidden="true"></i>

You can filter the list of users by any of the column headers.

> [!NOTE]
> Right-click a column to add any additional columns you want to filter by.

1. Go to the **Associates** tab.
1. Right-click a column heading or click <i class="ph ph-gear" aria-label="Gear"></i> in the top-right corner of the list.
1. Select **Enable filter**.
1. Click **OK**. Filter buttons are added to each column header.
1. Click <i class="ph ph-funnel" aria-label="Filter icon"></i> on the column you want to filter.
1. Select the relevant values in the list. Use the search function if the list is long.
1. Click **Filter**.
1. Repeat steps 5-7 to filter on additional columns.

#### Grouping the list

You can group the list of users by role, user plan, primary group, and similar. In addition, you can group on multiple levels.

> [!NOTE]
> Right-click a column to add any additional columns you want to group by (see also [Adjust views][14]).

1. Go to the **Associates** tab.
1. Right-click a column heading or click <i class="ph ph-gear" aria-label="Gear"></i> in the top-right corner of the list.
1. Select **Enable grouping**.
1. Click **OK**.
1. Click the column header for the value by which you want to group and drag it to the area above the columns ("Drag a column header and ..."). The list is now grouped by that value.
1. To group by additional values, click and drag another column header to the same area.
1. Click and drag the group values to change the order of the grouping levels.
1. Click a group value to change the sort order.

> [!NOTE]
> If you navigate to another tab, the grouping is reset.

#### User information

On the rightmost side of the window, there is detailed information about the user selected in the list of associates.

The full name, email address and owning company is displayed at the top. At the bottom of this section, you can activate/deactivate the user in SuperOffice using the **Can log in** button. Click the **Task** button to access functions such as **Move user** and for sending welcome emails and emails for resetting passwords.

There are different tabs in the User overview:

* **Details** - main overview of user information like **User ID**, **Role**, **User plan**, **Primary group** and **Service categories**.
* **Licences** - extra license information like **Condfidential activities** that will give the user the option to set **visible for** on follow-ups, documents and selections.
* **More** - the tab shows if there are any extra fields on person.

### <a id="other-users"></a>Other users (Onsite)

On the **Other users** tab in the Users screen, you can edit login rights for and add anonymous users and System users.

### <a id="our-companies"></a>Our companies

The object of the company list in the **Our companies** tab in the Users screen is to specify:

* Who can be defined as users of SuperOffice CRM. For a person to be registered as a SuperOffice CRM user, this person must be registered with a company displayed in the **Company** list box in the Users screen. And for a company to be displayed in the **Company** list box in the Users screen, the company must appear on the company list in the **Our companies** tab.

* Which companies can be defined as owners of a satellite.

#### Columns in the company list

| Column | Description |
|---|---|
| Company name | The company's name. |
| Department | The name of the department in the company. |
| City | Where the company is located. |
| Associates | How many associates have been created for the company. |
| Active satellite | Whether the company is recorded as an active satellite. |

### User licenses

On the **User licences** tab in the Users screen, you can get an overview of how many user licences are in use, and which users are using the various licences.

* Click a license in the **User licences** list to display a list of the users who are currently using this license.

* Hold the mouse-pointer over a license name to see detailed information about the license.

### User groups

On the **User groups** tab in the Users screen, you can get an overview of users and user groups. Click a group name in the **Available groups** list to display a list of the users who are currently assigned to this group.

## Related content

* [Manage your roles][6]
* [Add a new user][2]
* [Create a user group][3]
* [Change user plans for active users][17]

<!-- Referenced links -->
[2]: add-associate.md
[3]: user-groups.md
[4]: onsite/other-users.md#rights
[6]: role/index.md
[7]: role/functional-rights.md
[14]: ../adjusting-views.md
[15]: ../preferences/index.md
[16]: ../license/activate.md
[17]: ../license/change-user-plan.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/admin/access-right-system.png
[img2]: ../../../media/loc/en/admin/user-access-level.png
[img3]: ../../../media/loc/en/admin/admin-users-overview.png
[img5]: ../../../media/loc/en/admin/groups.png
[img6]: ../../../media/loc/en/admin/lists-grouping.png
[img7]: ../../../media/loc/en/admin/follow-up-type.png
[img8]: ../../../media/loc/en/admin/sales-group.png
