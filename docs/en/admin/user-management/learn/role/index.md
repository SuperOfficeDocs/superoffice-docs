---
uid: help-en-role
title: Role
description: Role
author: Kirsti Aakerholt
so.date: 04.19.2023
keywords: role, data object, user level
so.topic: concept
so.topic: admin
language: en
---

# Roles

[!include[Requirement](../includes/note-anon-req.md)]

Using role-based security in SuperOffice CRM, you can customize roles for different access levels in the company. The roles control the access rights the different users have in the SuperOffice CRM modules.

A role describes two things:

* Which **data objects** (company, contact, project, project members, selection, sale, stakeholder, follow-up, document, relation, dashboards and target) are to be made accessible for the users who have this role.

    Accessibility is specified using rights: none, read, create, update and delete.

* Which **functions** (for example, administrator access in Settings and maintenance, allow bulk update, quote approval, mail merge, exporting selections and publishing)  are to be made accessible to users with this role.

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

In the Roles section, you can [determine what type of access][6] your users have to the different parts of SuperOffice CRM. You can also customize each user level by changing the Data rights and/or the different Functional rights.

![The Roles section lets you determine what type of access your users have to the different parts of SuperOffice CRM -screenshot][img1]

You can, for example, decide whether a person can delete, update, create, or read information on the Data rights tab. On the Functional rights tab you can allow different functional rights on the different roles, like Allow bulk update, or List administrator, by moving them to the right column for "This role can".

| Role | Explanation | None | Read | Create | Update | Delete |
|---|---|:-:|:-:|:-:|:-:|:-:|
| None | No rights and cannot see | X |  |  |  |  |
| Read | Can read |  | X |  |  |  |
| Create | Can create |  | X | X |  |  |
| Update | Can update |  | X | X | X |  |
| Delete | Can delete |  | X | X | X | X |

## What would you like to do now?

* [Create a role][1]
* [Edit a role][2]
* [Set data rights for a role][3]
* [Edit rights for anonymous users][4]
* [Delete a role][5]
* [Set data rights for a role - Technical docs][6]

<!-- Referenced links -->
[1]: create-role.md
[2]: editing-role.md
[3]: set-data-rights-for-role.md
[4]: edit-rights-for-anonymous-users.md
[5]: deleting-role.md
[6]: ../role/set-data-rights-for-role.md

<!-- Referenced images -->
[img1]: media/manage-user-levels.png
