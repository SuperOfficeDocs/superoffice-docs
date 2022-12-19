---
uid: help-en-role
title: Role
description: Role
author: SuperOffice RnD
so.date: 06.29.2022
keywords: Settings and maintenance, role
so.topic: help
language: en
---

# Roles

[!include[Requirement](../includes/note-anon-req.md)]

Using role-based security in SuperOffice CRM, you can customize roles for different access levels in the company.

A role describes two things:

* Which **data objects** are to be made accessible for the users who have this role for the users who have this role.

    Accessibility is specified using rights: none, read, create, update and delete.

    <details><summary>What are data objects?</summary>
    [!include[List of data objects](includes/list-of-data-objects.md)]
    </details>

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

## Roles in Service

[!include[Restricted access](../../../learn/includes/note-insufficient-rights.md)]

Roles are used as a tool for administrating users. You can link different properties to a role, such as profiles, workflow access and functional rights. When you assign a user to a role, the user automatically acquires these properties. The **Roles** screen displays a list of all available roles.

> [!NOTE]
> If your company uses SuperOffice CRM, the roles are managed from SuperOffice Settings and maintenance.

## What would you like to do now?

* [Create a role][1]
* [Edit a role][2]
* [Set data rights for a role][3]
* [Edit rights for anonymous users][4]
* [Delete a role][5]

<!-- Referenced links -->
[1]: create-role.md
[2]: editing-role.md
[3]: set-data-rights-for-role.md
[4]: edit-rights-for-anonymous-users.md
[5]: deleting-role.md

<!-- Referenced images -->
