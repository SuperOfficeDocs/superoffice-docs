---
uid: help-en-role
title: Role
description: Role
keywords: role, data object, user level
author: digitaldiina, kirstiaa
date: 10.24.2025
version: 10.4
content_type: concept
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: role
index: true
redirect_from: 
  - /en/online/identity/role/index
  - /en/admin/user-management/learn/role/index
language: en
---

# Roles

[!include[Requirement](../includes/note-anon-req.md)]

Using role-based security in SuperOffice CRM, you can customize roles for different access levels in the company. The roles control the access rights the different users have in the SuperOffice CRM modules.

A role describes two things:

* Which **data objects** (company, contact, project, project members, selection, sale, stakeholder, follow-up, document, relation, dashboards, and target) to make accessible for the users who have this role.

    Accessibility is specified using rights: none, read, create, update, and delete.

* Which **functions** (for example, administrator access in Settings and maintenance, allow bulk update, quote approval, mail merge, exporting selections and publishing) to make accessible to users with this role.

> [!NOTE]
> All users must have one role and belong to a primary user group. They may also belong to other (secondary) groups.

## Predefined roles

Predefined roles are included with SuperOffice CRM. The **User levels 0–5** roles correspond to the user levels from previous versions of SuperOffice, where user level 0 is an administrator. You can edit these roles at will.

| Role | Explanation |
|---|---|
| User level 0 | Administrator: Has full access to all data. Can maintain all parts of the system. |
| User level 1 | Superuser: Has full access to data, but cannot maintain the system. |
| User level 2 | Has full access within own user group, but limited access beyond that. |
| User level 3 | Has full access to own data and can read data within own user group, but limited access beyond that. |
| User level 4 | Has full access to own data, but limited access within own user group and beyond that. |
| User level 5 | Has read access to most data, but limited access to others' data. Can create activities. |
| List administrator | Has full access to data in the SuperOffice CRM client. Can use Settings and maintenance to edit lists in the system (for example, lists of document templates and categories). |
| User administrator | Has full access to data. Can use Settings and maintenance to create and edit users in the system. |
| Local user | Has full access to own data, but no access to data belonging to users linked to other companies. |
| External user | Consultant or partner with limited access to company and project data. Has access only to published data. |
| Anonymous user | Anonymous user |
| System user | System integration user. Overrides all security controls. This role is not visible and cannot be edited. |

### User or Administrator role

When giving access to someone new, you must specify their role – either a user or an administrator.

Administrators have access to the Settings and maintenance section. This is where you can create users, adjust access rights and customize the CRM solution to your needs. If you want a user to have this access, give him or her user level 0.

If you do not want users to have access to Settings and maintenance, assign user level 1 or higher, depending on the access they need.

## Manage your roles

In the Roles section, you can [determine what type of access][3] your users have to the different parts of SuperOffice CRM. You can also customize each user level by changing the data rights and/or the different [functional rights][6].

![The Roles section lets you determine what type of access your users have to the different parts of SuperOffice CRM -screenshot][img1]

You can decide whether a person can delete, update, create, or read information on the **Data rights** tab.

| Role | Explanation | None | Read | Create | Update | Delete |
|---|---|:-:|:-:|:-:|:-:|:-:|
| None | No rights and cannot see | X |  |  |  |  |
| Read | Can read |  | X |  |  |  |
| Create | Can create |  | X | X |  |  |
| Update | Can update |  | X | X | X |  |
| Delete | Can delete |  | X | X | X | X |

You can set different access rights for each data object. For example, in Settings and maintenance, you selected a role **User level 1** (a) and set **Delete** (b) right to a company data object under the primary group column. This configuration means that any user who has User level 1 role will be able to read, create, update and delete all the companies that belong to other users who are members of his/her primary group.

On the **Functional rights** tab you can allow different functional rights on the different roles, such as *Allow bulk update*, or *List administrator*, by moving them to the right column for "This role can".

![Functional rights -screenshot][img4]

## Related content

* [Create a role][1]
* [Edit or delete a role][2]
* [Set data rights for a role][3]

<!-- Referenced links -->
[1]: create-role.md
[2]: update-role.md
[3]: set-data-rights-for-role.md
[6]: functional-rights.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/admin/manage-user-levels.png
[img4]: ../../../../media/loc/en/admin/functional-rights.png
