---
uid: help-en-users
title: Users
description: Learn how to add new users, how to assign the right user roles and groups, and help the users with setup and WebTools.
author: Bergfrid Dias
so.date: 08.25.2023
keywords: user
so.topic: concept
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Users

As an administrator you are in charge of adding and managing your users.

SuperOffice CRM uses a role- and group-based access right system. It means that **every SuperOffice user has a role and belongs to a primary group** (these are mandatory settings).

The following diagram shows a model of how the access right system works in SuperOffice CRM.

![Diagram showing the access right system][img1]

A [role][1] has a set of data and [functional rights][7], and a group setting grants access to data objects, various SuperOffice lists, and helps to set system preferences more efficiently.

The system allows you to configure access to companies, contacts, projects, project members, selections, sales, stakeholders (of sales), follow-ups, documents (including emails and mailings), relations (contact and company), and dashboards. All these different types of records are called **data objects**.

Each data object belongs to a user who might be you yourself (a), users in your primary group (b), users that belong to your other groups (c), other associates to whom you are not connected by any of your groups (d), external users (e), and anonymous users (f).

![The Roles - Associates screen, data rights tab -screenshot][img2]

The ownership of different data objects is set in different fields. For example, in the Company card the field called **Our Contact** specifies the owner of the record. For follow-ups, it is the field **Owner**, in the project **Responsible**, and so on.

## User types

* **Associates**: SuperOffice CRM users (in your company)

* **Other users**: Anonymous users and system users (onsite only)

* **Anonymous users**: Users with limited rights defined by the [role for anonymous users][4]. Anonymous users can be used, for instance, to provide access to web pages. In this way, salespersons can make relevant information from SuperOffice CRM available on a website that does not require a login, to give customers easy access to it.

* **System users**: [!include[Access rights](includes/def-system-user.md)]

    The system user is intended for integration and can be used to allow processes full access to the SuperOffice database for replicating diaries, for example.

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

## Related content

* [The Users screen][5]
* [Manage your roles][1]
* [Add a new user][2]
* [Create a user group][6]
* [Change user plans for active users][3]
* [Install WebTools for your users][17]

<!-- Referenced links -->
[1]: role/index.md
[2]: add-associate.md
[3]: change-user-plan.md
[4]: role/edit-rights-for-anonymous-users.md
[5]: screen/index.md
[6]: user-groups.md
[7]: role/functional-rights.md
[15]: ../../preferences/learn/index.md
[16]: ../../license/learn/activate.md
[17]: ../../../webtools/learn/install.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/access-right-system.png
[img2]: ../../../../media/loc/en/admin/user-access-level.png
[img5]: ../../../../media/loc/en/admin/groups.png
[img6]: ../../../../media/loc/en/admin/lists-grouping.png
[img7]: ../../../../media/loc/en/admin/follow-up-type.png
[img8]: ../../../../media/loc/en/admin/sales-group.png
